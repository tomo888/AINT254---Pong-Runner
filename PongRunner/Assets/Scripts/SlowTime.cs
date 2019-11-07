using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    public bool upgrade = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            upgrade = true;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (upgrade == true)
        {
            Time.timeScale = 0.5f;
            System.Threading.Thread.Sleep(5000);
            Time.timeScale = 1.0f;
        }

        else
        {
            Time.timeScale = 1.0f;
        }

    }

    void destroy()
    {
    }
}
