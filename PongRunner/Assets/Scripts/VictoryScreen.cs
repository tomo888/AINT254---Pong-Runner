using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryScreen : MonoBehaviour
{
    /**this class enables a UI panel when the player finishes the level, and also 
     * disables player control.**/
    public GameObject victoryPanel;
    public GameObject paddle;
    void Start()
    {
        StartCoroutine(PlayerWin());
    }

    IEnumerator PlayerWin()
    {
        yield return new WaitForSeconds(19);
        victoryPanel.SetActive(true);
        paddle.GetComponent<PlayerMovement>().enabled = false;
    }
}
