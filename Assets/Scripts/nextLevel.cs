using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour {

    public int minScore = 0;
	// Use this for initialization
	void Start () {
 
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        GameObject gObj = other.gameObject;

        PlayerHealth ph = gObj.GetComponent<PlayerHealth>();

        int points = ph.getPValue();

        if (gObj.CompareTag("Player") && points > minScore)
        {
            if (PlayerPrefs.HasKey("highscore"))
            {
                PlayerPrefs.SetString("highscore",PlayerPrefs.GetString("highscore")+ "." + points);
            }
            else
            {
                PlayerPrefs.SetString("highscore","" + points);
            }


            Debug.Log("test" + PlayerPrefs.GetString("highscore"));

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }


    }
}
