using UnityEngine;

public class objectMover : MonoBehaviour
{
    public float moveSpeed = 0.5f; // Speed at which the object moves
    public float minZ = -15.0f; // Minimum X position
    public float maxZ = 7.0f; // Maximum X position

    private int direction = 1; // Initial movement direction (1 for right, -1 for left)

    void Update()
    {
        // Calculate the object's next position based on speed and direction
        float newPosition = transform.position.z + (direction * moveSpeed * Time.deltaTime);

        // Check if the object reaches the range limits, change direction if so
        if (newPosition >= maxZ || newPosition <= minZ)
        {
            direction *= -1; // Reverse the direction
        }

        // Update the object's position
        transform.position = new Vector3(transform.position.x, transform.position.y, newPosition);
    }
}
