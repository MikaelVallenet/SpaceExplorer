using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotation : MonoBehaviour
{

    public float localRotationSpeed;
    public float revolutionSpeed;
    public Transform earth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frames
    void Update()
    {
        this.transform.Rotate(Vector3.up, localRotationSpeed * Time.deltaTime, Space.Self);
        this.transform.RotateAround(earth.position, Vector3.up, Time.deltaTime * revolutionSpeed);
    }
}
