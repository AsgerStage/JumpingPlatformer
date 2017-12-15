using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class highscoreList : MonoBehaviour {

    public Text highscore;

    // Use this for initialization
    void Start () {

         string test = "";
         string[] players = PlayerPrefs.GetString("highscore").Split('_');

   

        int[] scores = new int[players.Length];
        string[] playerHighscore = new string[players.Length];
        for (int i = 0; i <= players.Length - 1; i++)
        {
            string[] temp = players[i].Split('-');
            scores[i] = Int32.Parse(temp[0]);
            playerHighscore[i] = temp[1];
        }

        int tempInt;
        string tempString;
        for (int i = 0; i <= scores.Length -1 ; i++)
        {
            for (int j = 0; j <= scores.Length -1 ; j++)
            {
            
                if (scores[i] > scores[j])
                {
                    tempInt = scores[i];
                    scores[i] = scores[j];
                    scores[j] = tempInt;

                    tempString = playerHighscore[i];
                    playerHighscore[i] = playerHighscore[j];
                    playerHighscore[j] = tempString;
                }

            }
        }

        int run;
        if (players.Length > 10)
            run = 10;
        else
            run = players.Length - 1;
        for (int i = 0; i < run ; i++)
        {
            test = test + playerHighscore[i] + "   " + scores[i] + "\r\n";
        }

          highscore.text = test;
    }
}
