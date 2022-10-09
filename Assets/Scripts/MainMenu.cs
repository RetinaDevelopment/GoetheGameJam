using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene(1);
        FindObjectOfType<AudioManager>().Play("click");
    }

    public void quitButton()
    {
        Application.Quit();
        FindObjectOfType<AudioManager>().Play("click");
    }
}
