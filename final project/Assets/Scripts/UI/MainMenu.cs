using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("Intro");
    }

    public void Restart() {
        SceneManager.LoadScene("AreaOne");
    }

    void OpenOptions()
    {
        GetComponent<Canvas>().enabled = true;   
    }

    void CloseOptions()
    {
        GetComponent<Canvas>().enabled = false;
    }

    public void QuitGame() {
        Application.Quit();
    }
}
