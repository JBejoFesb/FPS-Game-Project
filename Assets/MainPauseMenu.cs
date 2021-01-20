using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPauseMenu : MonoBehaviour
{
    public static bool IsGamePaused = false;

    public GameObject pauseMenuUI;

    public GameObject optionsMenuUI;

    public GameObject failMenuUI;

    public GameObject laser;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsGamePaused)
                Resume();
            else
                Pause();
        }

        if(!IsGamePaused)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }

    public void Resume()
    {
        laser.SetActive(true);
        Debug.Log("OdPauzirano");
        pauseMenuUI.SetActive(false);
        optionsMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        IsGamePaused = false;

    }

    void Pause()
    {
        laser.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0.0f;
        IsGamePaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
    }

    public void TryAgain()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Game");
    }

    
}
