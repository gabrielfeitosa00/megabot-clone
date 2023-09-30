using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                SceneManager.LoadSceneAsync(3, LoadSceneMode.Additive);
            }
            else
            {
                Time.timeScale = 1;
                SceneManager.UnloadSceneAsync(3);
            }
        }
    }
}
