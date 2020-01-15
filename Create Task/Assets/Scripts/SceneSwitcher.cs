using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GoToDeathScene()
    {
        SceneManager.LoadScene("Death");
    }

    public void GoToGameStart()
    {
        SceneManager.LoadScene("DesignScene");
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Start");
    }
}
