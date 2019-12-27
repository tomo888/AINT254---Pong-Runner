using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeSystem : MonoBehaviour
{

    public int totalLives = 3;
    public static int livesRemaining = 3;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            lifeAway();

            if (livesRemaining <= 0)
            {
                StartCoroutine(gameOver());
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
    IEnumerator gameOver()
    {
        Debug.Log("Game Over");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("GameOver");
    }
}
