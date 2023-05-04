using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float moveSpeed;
    [SerializeField] Transform orientation;
    [SerializeField] float groundDrag;

    float horizontalInput;
    float verticalInput;

    [Header("Ground")]
    [SerializeField] float playerHeight;
    [SerializeField] LayerMask whatIsGround;
    bool grounded;

    Vector3 moveDirection;
    Rigidbody rb;

    [Header("Animation")]
    [SerializeField] Animator chefAnimator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);

        if (grounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = 0;
        }
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        // Checks if input is pressed then plays animation
        if (horizontalInput != 0 || verticalInput != 0)
        {
            chefAnimator.SetBool("isWalking", true);
        }
        else
        {
            chefAnimator.SetBool("isWalking", false);
        }

        //Get vector for the inputs
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        
        //Add force of the calculated movement vector
        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }
}
