using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public GameObject rb;
    public float rotationSpeed;
    private Vector3 rotation;
    private Vector3 rotPosition;

    private void Start()
    {
        rotation = new Vector3(0, 1, 0);
        rotPosition = new Vector3(-9.5f, 0.5f, 16.3f);
    }

    private void FixedUpdate()
    {
        rb.transform.RotateAround(rotPosition, rotation, rotationSpeed);
    }
}
