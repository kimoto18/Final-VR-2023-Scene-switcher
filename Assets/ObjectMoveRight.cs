using UnityEngine;

public class MoveForwardAndStop : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed as needed
    private float timer = 2f; // Time in seconds before stopping

    void Update()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;

            // Move the object forward
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        else
        {
            // Stop moving after 2 seconds
            // You can optionally add additional logic or functionality here
        }
    }
}