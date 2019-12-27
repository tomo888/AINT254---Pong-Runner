using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObstacle : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
    }
}
