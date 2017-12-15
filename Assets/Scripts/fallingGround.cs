using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingGround : MonoBehaviour {

    public GameObject activeObject;

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject gObj = other.gameObject;

        if (gObj.CompareTag("Player"))
        {
            StartCoroutine("active");
        }
    }

    IEnumerator active()
    {
        yield return new WaitForSeconds(0.2f);

        Vector3 pos = activeObject.transform.position;

        transform.position = new Vector2(0, -100);

        yield return new WaitForSeconds(5f);

        transform.position = new Vector2(pos.x, pos.y);

    }



}