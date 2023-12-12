using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  // Speed of the train.
    public float distanceToStop = 10f; // Distance to stop the train.
    public Vector3 initialPosition;  // Starting position of the train.
    private bool isMovingForward = true;  // Flag to track the train's direction.

    void Start()
    {
        // Store the initial position of the train.
        initialPosition = transform.position;
    }

    void Update()
    {
        if (isMovingForward)
        {
            // Move the train forward.
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

            // Check if the train has traveled the specified distance.
            if (Vector3.Distance(initialPosition, transform.position) >= distanceToStop)
            {
                // Stop the train when it reaches the specified distance.
                isMovingForward = false;
            }
        }
        else
        {
            // Move the train back to its initial position.
            transform.position = Vector3.MoveTowards(transform.position, initialPosition, moveSpeed * Time.deltaTime);

            // Check if the train has reached its initial position.
            if (Vector3.Distance(transform.position, initialPosition) < 0.01f)
            {
                // Reset the flag and start moving forward again.
                isMovingForward = true;
            }
        }
    }
}