using System.Collections;
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
        int points = ph.getPValue();
        int deaths = ph.getAttempts();

     

        if (PlayerPrefs.HasKey("highscore"))
        {
         
            PlayerPrefs.SetString("highscore", PlayerPrefs.GetString("highscore") + "_"+ (points - (deaths * 2))+"-"+highscoreName.text);

            string[] players = PlayerPrefs.GetString("highscore").Split('_');
          

          

          

            PlayerPrefs.SetString("highscore", "");

            for (int i = 0; i <= players.Length-1; i++)
            {
                if(i == 0)
                    PlayerPrefs.SetString("highscore", PlayerPrefs.GetString("highscore") + players[players.Length - 1 - i]);

                else
                    PlayerPrefs.SetString("highscore", PlayerPrefs.GetString("highscore") + "_"+ players[players.Length-1-i]);
            }

        }
        else
        {
            PlayerPrefs.SetString("highscore", (points - (deaths * 2))+"-"+highscoreName.text);
        }

        SceneManager.LoadScene("Menu");
    }

}
