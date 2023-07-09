using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform player; // Reference to the player object
    public GameObject otherCollider; // Collider of the other empty game object for respawning
    public Transform respawnPoint; // Respawn point for the player

    private Vector3 initialPosition; // Initial position of the player

    private void Start()
    {
        initialPosition = player.position; // Store the initial position of the player
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == otherCollider)
        {
            // Respawn the player at the respawn point
            player.position = respawnPoint.position;
            player.rotation = respawnPoint.rotation;
        }
    }
}
