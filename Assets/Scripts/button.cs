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

            StartCoroutine("active");
        }
    }

    IEnumerator active()
    {


        gameObject.GetComponent<BoxCollider2D>().isTrigger = false;

        yield return new WaitForSeconds(0.2f);
        
        activeObject.SetActive(!activeObject.activeSelf);
        Debug.Log("hit!");

    }



}
