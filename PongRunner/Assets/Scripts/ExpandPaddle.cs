using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandPaddle : MonoBehaviour
{
    public float multiplier = 2.0f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            onPickup(GameObject.Find("Paddle"));
        }
    }

    void onPickup(GameObject gameObject)
    {
        gameObject.transform.localScale *= multiplier;
        destroy();
    }

    void destroy()
    {
        Destroy(gameObject);
    }
}
