using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    public bool upgrade = false;
    public GameObject paddle;
    public GameObject pickupEffect;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            upgrade = true;
            StartCoroutine(Timer());
        }
    }

    void Update()
    {

            

    }
    IEnumerator Timer()
    {
        if (Time.timeScale == 1.0f)
        {
            Instantiate(pickupEffect, transform.position, transform.rotation);
            Time.timeScale = 0.5f;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
            paddle.GetComponent<PlayerMovement>().speed *= 2.3f;
            /**More than doubled player speed here because turning seems to become quite sticky
            when power-up is active, so this compensates for it.**/
        }
        yield return new WaitForSeconds(2);
        Debug.Log("Slow Deactivated!");
        upgrade = false;
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
        paddle.GetComponent<PlayerMovement>().speed /= 2.3f;
        Destroy(gameObject);
    }
}
