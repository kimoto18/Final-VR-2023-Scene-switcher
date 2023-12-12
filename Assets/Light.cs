using UnityEngine;

public class Light : MonoBehaviour
{
    public Transform lightTransform; // Reference to the light's transform.
    public float moveSpeed = 1.0f; // Speed of the light movement.
    public float maxHeight = 5.0f; // Adjust this value to set the maximum height.

    private Vector3 initialPosition;
    private bool moveUp = true;

    private void Start()
    {
        // Store the initial position of the light.
        initialPosition = lightTransform.localPosition;
    }

    private void Update()
    {
        // Move the light up and down within the GameObject.
        Vector3 newPosition = lightTransform.localPosition;

        if (moveUp)
        {
            newPosition.y += moveSpeed * Time.deltaTime;
            if (newPosition.y >= initialPosition.y + maxHeight)
            {
                moveUp = false;
            }
        }
        else
        {
            newPosition.y -= moveSpeed * Time.deltaTime;
            if (newPosition.y <= initialPosition.y)
            {
                moveUp = true;
            }
        }

        lightTransform.localPosition = newPosition;
    }
}