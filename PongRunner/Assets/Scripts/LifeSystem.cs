using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeSystem : MonoBehaviour
{

    public int lives = 3;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            if (lives <= 0)
            {
                gameOver();
            }

            else
            {
                lifeAway();
                Debug.Log("Life gone. Lives remaining: " + lives);
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
        lives -= 1;
        return lives;
    }
    void gameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
