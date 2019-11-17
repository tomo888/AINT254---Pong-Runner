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
        }
    }

    void Update()
    {
        if (upgrade == true)
        {
            if (Time.timeScale == 1.0f)
                {
                    Time.timeScale = 0.5f;
                    Time.fixedDeltaTime = 0.02f * Time.timeScale;
                    destroy();
            }
        }
            

    }

    void destroy()
    {
        Destroy(gameObject);
    }
}
