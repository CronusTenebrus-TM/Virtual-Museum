using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindWithTag("Player") == true)
        {
            Application.Quit();
        }
    }
}
