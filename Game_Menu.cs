using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Menu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuGUI;

    

    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            if(gameIsPaused)
            {
                //Resume();
            }else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        
        pauseMenuGUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        
    }

    void Pause()
    {
        pauseMenuGUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void Restart()
    {
         //SceneManager.LoadScene(SceneManager.GetActiveScene().SampleScene);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
}