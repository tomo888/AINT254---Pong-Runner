using UnityEngine;

public class BallAudioManager : MonoBehaviour
{
    /**handles in-game audio caused by ball coming into contact with triggers**/
    public AudioSource wallCollide;
    public AudioSource paddleCollide;
    public AudioSource powerUpCollide;
    public AudioSource obstacleCollide;
    public AudioSource gameOverAudio;
    public GameObject ball;

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

        else if (other.CompareTag("Player")) //ie. ball
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
            if (ball.GetComponent<LifeSystem>().livesRemaining != 0) //determines if obstacle hit or game over audio should be played
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
