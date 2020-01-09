using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    /**this method handles the power up's visual effects, effects on gameplay
    * as well as having an in-built timer.**/
    public GameObject pickupEffect;
    public GameObject ball;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball") && ball.GetComponent<LifeSystem>().livesRemaining != ball.GetComponent<LifeSystem>().totalLives)
        {
            Instantiate(pickupEffect, transform.position, transform.rotation);
            ball.GetComponent<LifeSystem>().livesRemaining += 1;
            Destroy(gameObject);
        }
    }
}
