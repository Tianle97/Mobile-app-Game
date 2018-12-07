using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Utilities;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPause = false;

    public GameObject pauseMenuUI;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestatGame();
        }
	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
    
    public void QuitGame()
    {
        GameIsPause = false;
        SceneManager.LoadScene(SceneNames.STRAT);
        Debug.Log("Go to the MainMenu");
    }

    public void RestatGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
