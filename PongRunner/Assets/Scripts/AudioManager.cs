using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource wallCollide;
    public AudioSource paddleCollide;
    public AudioSource powerUpCollide;
    public AudioSource obstacleCollide;
    public AudioSource gameOverAudio;

    void Start()
    {
        AudioSource wallCollide = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            Debug.Log("It should be playing!");
            wallCollide.Play();
        }

        else if (other.CompareTag("Player"))
        {
            Debug.Log("Paddle hit!");
            paddleCollide.Play();
        }

        else if (other.CompareTag("Power Up"))
        {
            Debug.Log("Power Up hit!");
            powerUpCollide.Play();
        }

        else if (other.CompareTag("Obstacle"))
        {
            if (LifeSystem.livesRemaining != 0)
            {
                Debug.Log("Obstacle hit!");
                obstacleCollide.Play();
            }

            else
            {
                Debug.Log("Game over man! Game over!");
                gameOverAudio.Play();
            }
        }

    }
}
