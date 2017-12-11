using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {

    public GameObject activeObject;

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject gObj = other.gameObject;

        if (gObj.CompareTag("Player"))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            activeObject.SetActive(true);
        }
    }
}
