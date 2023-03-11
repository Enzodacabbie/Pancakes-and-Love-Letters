using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCam : MonoBehaviour{
    [Header("References")]
    public Transform orientation;
    public Transform player;
    public Transform model;
    public Rigidbody rb;

    public float rotationSpeed;

    public CameraStyle currentStyle;

    public enum CameraStyle{
        Basic,
        Combat,
        Tomdown
    }

    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update(){
        //rotate orientation
        Vector3 viewDir = player.position - new Vector3(transform.position.x, transform.position.y, transform.position.z);
        orientation.forward = viewDir.normalized;

        //rotate player object
        float horizontalInput = Input.GetAxis("Horizontal");
        float vertialInput = Input.GetAxis("Vertical");
        Vector3 inputDir = orientation.forward * vertialInput + orientation.right * horizontalInput;

        if(inputDir != Vector3.zero){
            model.forward = Vector3.Slerp(model.forward, inputDir.normalized, Time.deltaTime * rotationSpeed);
        }
    }
}
