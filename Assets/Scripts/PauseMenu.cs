using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {

    GameObject pauseMenu;
    bool paused;

	void Start () {
        paused = false;
        pauseMenu = GameObject.Find("PauseMenu");
	}
	
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
