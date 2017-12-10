using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class coinCollect : MonoBehaviour {

    public int pickupValue = 5;

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject gObj = other.gameObject;

        if (gObj.CompareTag("Player"))
        {
            // Add pickupValue to total score here
            if (gameObject.tag == "pickUp")
            {
                Debug.Log("coin pickup");
            }
            else if (gameObject.tag == "toxic")
            {
                Debug.Log("Toxic pickup");
                SceneManager.LoadScene("Platformer");
            }
            Destroy(gameObject);
        }
    }
}
