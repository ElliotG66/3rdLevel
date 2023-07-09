using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    public float verticalDistance = 5f; // The distance the object moves vertically
    public float movementSpeed = 2f; // The speed at which the object moves

    private float originalY; // The original Y position of the object
    private float targetY; // The target Y position for the object

    private void Start()
    {
        originalY = transform.position.y;
        targetY = originalY + verticalDistance;
    }

    private void Update()
    {
        // Move the object vertically
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, targetY, transform.position.z), movementSpeed * Time.deltaTime);

        // Check if the object has reached the target Y position
        if (Vector3.Distance(transform.position, new Vector3(transform.position.x, targetY, transform.position.z)) < 0.01f)
        {
            // Swap the target Y position to move in the opposite direction
            targetY = (targetY == originalY) ? originalY + verticalDistance : originalY;
        }
    }
}
