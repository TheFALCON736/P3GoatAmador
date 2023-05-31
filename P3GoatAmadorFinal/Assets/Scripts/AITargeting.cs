using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITargeting : MonoBehaviour
{
    public Transform mainCharacter;        // Reference to the main character's transform
    public float movementSpeed = 5f;       // AI movement speed

    private Rigidbody rb;                  // Reference to the AI character's Rigidbody component

    private int score = 0;                  // Score counter

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Calculate the direction from AI to the main character
        Vector3 direction = (mainCharacter.position - transform.position).normalized;

        // Rotate the AI character to face the main character
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        rb.MoveRotation(lookRotation);

        // Move the AI character towards the main character
        rb.MovePosition(transform.position + direction * movementSpeed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the main character
        if (collision.gameObject.CompareTag("Player"))
        {
            // Increase the score
            score++;

            // Output the updated score
            Debug.Log("Score: " + score);

            // Destroy the AI character
            Destroy(gameObject);
        }
    }
}

