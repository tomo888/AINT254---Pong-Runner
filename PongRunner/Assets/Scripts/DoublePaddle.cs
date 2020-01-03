using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoublePaddle : MonoBehaviour
{
    public GameObject pickupEffect;
    public GameObject normalPaddle;
    public GameObject doublePaddle1;
    public GameObject doublePaddle2;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            StartCoroutine(Timer());
        }
    }
    IEnumerator Timer()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
        normalPaddle.GetComponent<MeshRenderer>().enabled = false;
        normalPaddle.GetComponent<Collider>().enabled = false;
        doublePaddle1.SetActive(true);
        doublePaddle2.SetActive(true);
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(6);
        normalPaddle.GetComponent<MeshRenderer>().enabled = true;
        normalPaddle.GetComponent<Collider>().enabled = true;
        doublePaddle1.SetActive(false);
        doublePaddle2.SetActive(false); 
        Destroy(gameObject);
        /**I opted to disable the MeshRenderer and Collider for the normal paddle,
         * rather than disabling the GameObject, as simply disabling the GameObject will cause it to appear at the 
         * position it was at just before the power-up was picked up, rather than
         * where the two paddles are at the moment the power-up ends. Doing this enables the normal paddle to still
         * follow player movement whilst the power-up is active.**/
    }
}
