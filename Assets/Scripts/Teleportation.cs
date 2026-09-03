using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GameObject player;
    public Vector3 position;
    private void OnTriggerEnter(Collider other)
    {
        if (player)
        {
            player.transform.position = position;
        }
    }
}
