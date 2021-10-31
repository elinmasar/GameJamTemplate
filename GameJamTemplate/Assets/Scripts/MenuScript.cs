using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void PauseGame()
    {
        SceneManager.LoadScene("MenuScreen");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
