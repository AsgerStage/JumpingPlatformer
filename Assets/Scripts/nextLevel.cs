using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour {

    public int minScore = 0;
    public GameObject activeObject;

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject gObj = other.gameObject;
        PlayerHealth ph = gObj.GetComponent<PlayerHealth>();
        int points = ph.getPValue();

        if (gObj.CompareTag("Player") && points > minScore)
        {
            activeObject.SetActive(true);
            try
            { 
               SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            catch { }
        }

  


    }
}
