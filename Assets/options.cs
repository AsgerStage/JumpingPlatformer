﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class options : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void deleteHighscore()
    {
        Debug.Log("done");
        PlayerPrefs.SetString("highscore", "");
    }
}
