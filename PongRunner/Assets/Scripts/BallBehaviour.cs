using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BallBehaviour : MonoBehaviour
{
    public Vector3 initialImpulse;
    public float maxSpeed;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse);
    }
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
    }
}
