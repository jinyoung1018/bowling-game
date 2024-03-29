﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused ;
    public GameObject pauseMenuUI;

    private void Awake()
    {
        Resume();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            Resume();
        else
                Pause();
        }
            
    }
     void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;

        GameIsPaused = false;

    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true; 
    }
   public void GoToMainMenu()
    {
        Loader.Instance.Load(0);

        GameManage.Instance.kalanHak = 2;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
