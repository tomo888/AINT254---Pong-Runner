using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandPaddle : MonoBehaviour
{
    /**this method handles the power up's visual effects, effects on gameplay
     * as well as having an in-built timer.**/
    public float multiplier = 2.0f; //stored this in a variable, as I may update this with a random modifier for the size change.
    public GameObject pickupEffect; //visual effect
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
