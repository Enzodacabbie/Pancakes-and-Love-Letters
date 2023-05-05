using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    public Animator animator;

    public NavMeshAgent npc;
    public LayerMask whatIsGround;

    // Patrolling variables
    public Vector3 walkPoint;
    public float walkPointRange;
    public float timeWalk;

    private float timerWalking;
    private bool walkPointSet;

    // Start is called before the first frame update
    void Start()
    {
        walkPointSet = false;
        timerWalking = timeWalk;
        animator.SetBool("isWalking", false);
    }

    // Update is called once per frame
    void Update()
    {
        RandomPatrol();
    }

    void RandomPatrol()
    {
        if (!walkPointSet)
        {
            RandomWalkPoint();
        }

        if (walkPointSet)
        {
            npc.SetDestination(walkPoint);
            animator.SetBool("isWalking", true);
        }

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        if (timerWalking > 0f)
        {
            timerWalking -= Time.deltaTime;
        }

        if (distanceToWalkPoint.magnitude < 1f || timerWalking <= 0f)
        {
            walkPointSet = false;
            timerWalking = timeWalk;
        }
    }

    private void RandomWalkPoint()
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
        {
            walkPointSet = true;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, walkPointRange);
    }
}
