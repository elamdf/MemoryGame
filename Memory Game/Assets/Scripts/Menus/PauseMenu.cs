﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public Button resumeButton;
    public Button restartButton;
    public Button quitButton;
    public Button menuButton;
    void Start()
    {
        resumeButton.onClick.AddListener(Resume);
        restartButton.onClick.AddListener(restartGame);
        quitButton.onClick.AddListener(quitGame);
        menuButton.onClick.AddListener(toMenu);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                Resume();
            }else{
                Pause();
            }
        }
    }
    void toMenu () {
        SceneManager.LoadScene("MainMenu");
    }
    void quitGame (){
        Debug.Log("quit button time");
        Application.Quit();
    }
    void restartGame (){
  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  Time.timeScale = 1f;
    }
    void Resume()
    {
                pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
}