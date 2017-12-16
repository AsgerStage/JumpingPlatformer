using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFire : MonoBehaviour {

    public Transform firePoint;
    public GameObject gObj;
	// Use this for initialization
	void Start () {
        StartCoroutine("active");
    }

    IEnumerator active()
    {
        yield return new WaitForSeconds(1f);
        GameObject bullet= Instantiate(gObj, firePoint);
        bullet.transform.parent = null;
        StartCoroutine("active");

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(!other.gameObject.CompareTag("toxic"))
        StartCoroutine("kill");
    }

    IEnumerator kill()
    {
        yield return new WaitForSeconds(0.2f);
            Destroy(gameObject);

    }

}
