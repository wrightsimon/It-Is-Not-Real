using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;
    Animator animator;

    void Awake() 
    {
        agent = GetComponent<NavMeshAgent>();
        target = FindObjectOfType<PlayerMovement>().transform;
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);

        HandleAnimation();
    }

    void HandleAnimation() 
    {
        if (agent.velocity.magnitude <= 0)
        {
            animator.SetBool("IsWalking", false);
        } else {
            animator.SetBool("IsWalking", true);
        }
    }
}
