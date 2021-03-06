﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        PlayerPrefs.SetInt("attempts", 0);
        PlayerPrefs.SetInt("points", 0);

        if (!PlayerPrefs.HasKey("highscore"))
        {
            PlayerPrefs.SetString("highscore", "");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
