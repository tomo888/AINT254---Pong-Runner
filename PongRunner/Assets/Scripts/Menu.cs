using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    /**handles the menu interactions. I opted to seperate this from SceneChange
     * as the two, whilst similar in purpose, do function quite differently.**/
    public AudioSource buttonOver;
    public AudioSource buttonClick;
    public void PlayGame()
    {
        SceneManager.LoadScene("Level One");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ButtonHover()
    {
        buttonOver.Play();
    }

    public void ButtonClick()
    {
        buttonClick.Play();
    }
}
