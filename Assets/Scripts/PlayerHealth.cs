using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    public int health;
    public bool hasDied;
    public Text Score;
    private int count;

    // Use this for initialization
    void Start () {
        hasDied = false;
        count = 0;
        setCountText();

    }

	
	// Update is called once per frame
	void Update () {
        if (gameObject.transform.position.y < -3)
        {
            hasDied = true;
        }
        if (hasDied == true)
        {
            StartCoroutine("Die");
        }
	}
    IEnumerator Die()
    {
        SceneManager.LoadScene("Platformer");
        yield return null;
       

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject gObj = other.gameObject;

        if (gObj.CompareTag("pickUp"))
        {
            coinCollect cC = gObj.GetComponent<coinCollect>();
            count = count + cC.getPValue();
                setCountText();
        }

    }

    void setCountText()
    {
        Score.text = "Score: " + count.ToString();
    }

}
