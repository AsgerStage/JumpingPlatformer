using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {

    GameObject pauseMenu;
    bool paused;

	// Use this for initialization
	void Start () {
        paused = false;
        pauseMenu = GameObject.Find("PauseMenu");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
		
	}


    public void resumeGame()
    {
        paused = false;
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
