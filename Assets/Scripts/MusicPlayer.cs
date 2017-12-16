using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    AudioSource musicPlayer;
    static bool AudioBegin;


    private void Start()

    {
        DontDestroyOnLoad(gameObject);
       musicPlayer=GetComponent<AudioSource>();
        musicPlayer.loop = true;
    }

    void Awake()
    {

    }
    void Update()
    {
       // gameObject.transform.position=GameObject.FindGameObjectWithTag("MainCamera").transform.position;
        if (!AudioBegin)
        {
            musicPlayer.Play();

            //   DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
        /* if (Application.loadedLevelName == "Upgraded")
         {
             musicPlayer.Stop();
             AudioBegin = false;
         }*/
    }
}
