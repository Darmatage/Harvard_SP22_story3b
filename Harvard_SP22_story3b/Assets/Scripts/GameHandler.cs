
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{

    public static bool playerStat = true;
    //public GameObject textGameObject;


    public static bool GameisPaused = false;
    public GameObject pauseMenuUI;
    // pause menu

    void Start()
    {
        pauseMenuUI.SetActive(false);
        GameisPaused = false;
    }


    //void Start () { UpdateScore (); }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }


    // public void UpdatePlayerStat(int amount)
    // {
    //    playerStat += amount;
    //   Debug.Log("Current Player Stat = " + playerStat);
    //      UpdateScore ();
    //  }

    //public int CheckPlayerStat()
    // {
    //     return playerStat;
    //}

    //void UpdateScore () {
    //        Text scoreTemp = textGameObject.GetComponent<Text>();
    //        scoreTemp.text = "Score: " + score; }

    public void StartGame()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("Credits");
    }


    public void RestartGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
    }
}