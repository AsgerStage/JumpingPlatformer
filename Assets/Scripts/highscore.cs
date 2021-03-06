﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class highscore : MonoBehaviour {

    public InputField highscoreName;


    private void Update()
    {
        if (GameObject.Find("highScoreInput"))
        Time.timeScale = 0;
    }

    public void OnSubmit()
    {
    PlayerHealth ph = GameObject.Find("Player").GetComponent<PlayerHealth>();

        int points = PlayerPrefs.GetInt("points");
        int deaths = ph.getAttempts();

        if (PlayerPrefs.HasKey("highscore"))
        {
            if (PlayerPrefs.GetString("highscore").Equals(""))
            {
                PlayerPrefs.SetString("highscore", (points - (deaths * 2)) + "<" + highscoreName.text);
            }
            else
            {
                PlayerPrefs.SetString("highscore", PlayerPrefs.GetString("highscore") + "_" + (points - (deaths * 2)) + "<" + highscoreName.text);
            }
        }
        else
        {
            PlayerPrefs.SetString("highscore", (points - (deaths * 2))+"<"+highscoreName.text);
        }

        SceneManager.LoadScene("Menu");
    }

}
