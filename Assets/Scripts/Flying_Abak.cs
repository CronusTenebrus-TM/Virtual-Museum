using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying_Abak : MonoBehaviour {

    public GameObject go;
    public float rotationSpeed = 0.4f;
    public float x = 0f;
    public float y = 0f;
    public float z = 0f;
    private Vector3 rotation;
    private Vector3 rotPosition;

    private void Start()
    {
        rotation = new Vector3(0, 1, 0);
        rotPosition = new Vector3(x, y, z);
    }

    private void FixedUpdate()
    {
        go.transform.RotateAround(rotPosition, rotation, rotationSpeed);
    }
}
