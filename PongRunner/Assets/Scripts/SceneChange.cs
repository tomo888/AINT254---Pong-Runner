using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    /**this class is responsible for triggering the fade to black animation when the
     * appropriate conditions are met, as well as allowing me to insert scene changes
     * into the animator via the 'events' component.**/
    public Animator animator;
    public GameObject ball;

    public void Update()
    {
        if (ball.GetComponent<LifeSystem>().IsDead == true)
        {
            animator.SetTrigger("Game Over");
        }
    }

    public void LoadLevelOne()
    {
        FadeToScene("Level One");
    }

    public void VictoryLoadMenu()
    {
        FadeToScene("Victory Load Menu");
    }

    public void FadeToScene (string level)
    {
        if (level == "Level One")
        {
            animator.SetTrigger("Fade Out");
        }

        else if (level == "Victory Load Menu")
        {
            animator.SetTrigger("Victory");
        }
    }

    public void LevelOneFadeComplete()
    /**this is an event in animation; triggers a second after the trigger is activated
     * in FadeToScene, hence this needs to be a seperate method.**/
    {
        SceneManager.LoadScene("Level One");
    }

    public void GameOverFadeComplete()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void VictoryMenuFadeComplete()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
