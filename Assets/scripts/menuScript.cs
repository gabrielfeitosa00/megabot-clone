using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuManager : MonoBehaviour
{

    public void startGame()
    {

        SceneManager.LoadSceneAsync(1);
    }
    public void resumeGame()
    {
        Time.timeScale = 1;
        SceneManager.UnloadSceneAsync(3);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
