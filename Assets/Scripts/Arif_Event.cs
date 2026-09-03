using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arif_Event : MonoBehaviour {

    public GameObject panel;
    public GameObject panel_photo;

    void Start ()
    {
        panel.SetActive(false);
        panel_photo.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        panel.SetActive(true);
        panel_photo.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        panel.SetActive(false);
        panel_photo.SetActive(false);
    }
}
