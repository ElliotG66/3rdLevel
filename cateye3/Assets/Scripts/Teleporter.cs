using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    public GameObject Player;
    public GameObject Destination;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Teleporter"))
        {
            Player.transform.position = Destination.transform.position;
        }
    }
}
