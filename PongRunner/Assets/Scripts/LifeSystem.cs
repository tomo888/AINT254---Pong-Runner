using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifeSystem : MonoBehaviour
{

    public static int totalLives = 3;
    public int livesRemaining = totalLives;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            lifeAway();
            if (totalLives <= 0)
            {
                gameOver();
            }

            else
            {
                Debug.Log("Life gone. Lives remaining: " + totalLives);
            }

        }

    }

    private void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
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
    //need to destroy obstacle - look at ExpandPaddle
    void destroy()
    {
        Destroy(gameObject);
    }

    int lifeAway()
    {
        totalLives -= 1;
        return totalLives;
    }
    void gameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
