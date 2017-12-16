using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class options : MonoBehaviour {


    public Text highscore;

    public void deleteHighscore()
    {
        Debug.Log("done");
        PlayerPrefs.SetString("highscore", "");
        highscore.text = "";
    }
}
