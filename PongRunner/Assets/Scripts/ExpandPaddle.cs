using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandPaddle : MonoBehaviour
{
    public float multiplier = 2.0f;
    public GameObject pickupEffect;
    public GameObject paddle;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            StartCoroutine(Timer());
        }
    }
    IEnumerator Timer()
    {
        Debug.Log("It's working...");
        Instantiate(pickupEffect, transform.position, transform.rotation);
        paddle.transform.localScale *= multiplier;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(10);
        paddle.transform.localScale /= multiplier;
        Destroy(gameObject);
    }
}
