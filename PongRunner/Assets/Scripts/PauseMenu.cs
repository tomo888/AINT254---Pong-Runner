using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject pauseUI;
    public AudioSource gameST;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }
    void Pause()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        gameST.volume *= 0.25f; //quietens ambient soundtrack
        gamePaused = true;
    }

    public void Resume()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        gameST.volume = 0.4f;
        gamePaused = false;
    }

    public void loadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
