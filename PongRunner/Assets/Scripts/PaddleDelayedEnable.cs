using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleDelayedEnable : MonoBehaviour
{
    /**simply put, this prevents the player from using the paddle whilst the 
     * level countdown timer is still going. This prevents the paddle from being in
     * an unusual place at the start of gameplay.**/
    public GameObject paddle;

    private void Start()
    {
        StartCoroutine(Enable());
    }
    IEnumerator Enable()
    {
        yield return new WaitForSeconds(3);
        paddle.SetActive(true);
    }


}
