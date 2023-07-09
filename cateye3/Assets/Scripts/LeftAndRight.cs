using UnityEngine;

public class LeftAndRight : MonoBehaviour
{
    public float horizontalDistance = 5f; // The distance the object moves horizontally
    public float movementSpeed = 2f; // The speed at which the object moves

    private float originalX; // The original X position of the object
    private float targetX; // The target X position for the object

    private void Start()
    {
        originalX = transform.position.x;
        targetX = originalX + horizontalDistance;
    }

    private void Update()
    {
        // Move the object horizontally
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetX, transform.position.y, transform.position.z), movementSpeed * Time.deltaTime);

        // Check if the object has reached the target X position
        if (Vector3.Distance(transform.position, new Vector3(targetX, transform.position.y, transform.position.z)) < 0.01f)
        {
            // Swap the target X position to move in the opposite direction
            targetX = (targetX == originalX) ? originalX + horizontalDistance : originalX;
        }
    }
}
