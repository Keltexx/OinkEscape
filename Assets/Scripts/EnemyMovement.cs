﻿using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    Transform player;               // Reference to the player's position.
    //PlayerHealth playerHealth;      // Reference to the player's health.
    //EnemyHealth enemyHealth;        // Reference to this enemy's health.
    NavMeshAgent nav;               // Reference to the nav mesh agent.
    public float distancia = 1f;
    Animator anim;

    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //playerHealth = player.GetComponent<PlayerHealth>();
        //enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        // If the enemy and the player have health left...
        //if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        //{
        // ... set the destination of the nav mesh agent to the player.
        nav.SetDestination(player.position);
        //    }
        //    // Otherwise...
        //    else
        //    {
        //        // ... disable the nav mesh agent.
        //        nav.enabled = false;
        //    }


        if (Vector3.Distance(transform.position, player.position) < distancia)
        {
            anim.SetBool("EstaCerca", true);
            anim.SetBool("isWalking", false);
        }
        else
        {
            anim.SetBool("EstaCerca", false);
            anim.SetBool("isWalking", true);
        }
    }
}