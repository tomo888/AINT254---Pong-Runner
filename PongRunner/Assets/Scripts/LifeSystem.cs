using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeSystem : MonoBehaviour
{

    /**this class is responsible for dictacting the amount of lives the player
     * starts with; storing how many lives they have left; handling the change to 
     * the player's health UI; and disabling player control and letting the SceneChange
     * script know the player has failed.**/

    public int totalLives = 3;
    public int livesRemaining = 3;
    public bool IsDead = false;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public GameObject paddle;
    public GameObject deathEffect;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            lifeAway();

            if (livesRemaining <= 0)
            {
                StartCoroutine(GameOver());
            }

            else
            {
                Debug.Log("Life gone. Lives remaining: " + livesRemaining);
            }
        }

    }

    void Update()
    {
        if (livesRemaining > totalLives)
        {
            livesRemaining = totalLives; //error handling
        }
        for (int i = 0; i < hearts.Length; i++)
        {

            if (i < livesRemaining)
            {
                hearts[i].sprite = fullHeart;
            }

            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i < totalLives)
            {
                hearts[i].enabled = true;
            }

            else
            {
                hearts[i].enabled = false;
            }
        }
    }
    void destroy()
    {
        Destroy(gameObject);
    }

    int lifeAway()
    {
        livesRemaining -= 1;
        return livesRemaining;
    }
    IEnumerator GameOver()
    {
        Instantiate(deathEffect, transform.position, transform.rotation);
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        GetComponent<TrailRenderer>().enabled = false;
        paddle.GetComponent<PlayerMovement>().enabled = false;
        Debug.Log("Game Over");
        yield return new WaitForSeconds(2);
        IsDead = true;
    }
}
