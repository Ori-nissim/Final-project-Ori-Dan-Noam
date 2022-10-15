using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RobberMale : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Animator animator;
    public GameObject player;

    float distance;
    private bool isEnemyInRange = false;
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (!isEnemyInRange)
        {
            navMeshAgent.SetDestination(player.transform.position);
            checkDistanceFromTarget();
            lookOnPlayer();
        }

    }

    private void checkDistanceFromTarget()
    {
        distance = Vector3.Distance(gameObject.transform.position, player.transform.position);

        if (distance < 4.2f)
        {
            animator.CrossFade("Idle", 0.2f);
        }
        else
        {
            animator.Play("Walking");
        }
    }

    private void lookOnPlayer()  
    {
        Vector3 direction = player.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);

        transform.rotation = rotation;
    }

}
