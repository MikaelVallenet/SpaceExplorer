using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotation : MonoBehaviour
{

    public float localRotationSpeed;
    public float revolutionSpeed;
    public Transform sun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frames
    void Update()
    {
        this.transform.Rotate(Vector3.up, localRotationSpeed * Time.deltaTime, Space.Self);
        this.transform.RotateAround(sun.position, Vector3.up, Time.deltaTime * revolutionSpeed);
    }
}