using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("Intro");
    }

    void OpenOptions()
    {
        GetComponent<Canvas>().enabled = true;   
    }

    // Update is called once per frame
    void CloseOptions()
    {
        GetComponent<Canvas>().enabled = false;
    }

    public void QuitGame() {
        Application.Quit();
    }
}
