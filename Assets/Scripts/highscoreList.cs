using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscoreList : MonoBehaviour {

    public Text highscore;

    // Use this for initialization
    void Start () {

          string test = "";
     //   PlayerPrefs.SetString("highscore", "10-box"+"_"+ "16-box" + "_" + "15-box" + "_" + "13-box");
        string[] players = PlayerPrefs.GetString("highscore").Split('_');

        //   Debug.Log(players.Length);


      for(int i = 0; i <= players.Length-1; i++) {
        string[] scores = players[i].Split('-');
          test = test + scores[1] + " ";

        //          Debug.Log(players[i]);
           }


        
        Debug.Log(players[0].Split('-')[1]);
        Debug.Log(players[1]);
        Debug.Log(PlayerPrefs.GetString("highscore"));

          highscore.text = test;
        // highscore.text = PlayerPrefs.GetString("highscore");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
