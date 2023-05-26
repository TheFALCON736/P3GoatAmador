using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        // Example code to trigger attack and control movement speed
        bool attackInput = Input.GetButtonDown("Attack");
        float movementSpeedInput = Input.GetAxis("Vertical");


        animator.SetBool("Attack", attackInput);
        animator.SetFloat("MovementSpeed", movementSpeedInput);
    }
}

