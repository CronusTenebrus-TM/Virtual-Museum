using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MassegeToPlayer : MonoBehaviour
{
    public Text message;
    public Font font;
    public GameObject activator;

    private void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindWithTag("Player") == true)
        {
            message.font = font;
            message.text = "Welcome to the Virtual Museum!";
            message.enabled = true;
            StartCoroutine(DisableMessage());
        }
    }

    IEnumerator DisableMessage()
    {
        yield return new WaitForSecondsRealtime(5);
        message.enabled = false;
        activator.SetActive(false);
    }
}