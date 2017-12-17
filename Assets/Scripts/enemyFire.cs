using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFire : MonoBehaviour {

    public Transform firePoint;
    public GameObject gObj;
    public float y;
    bool isRunning = false;

    private void Update()
    {
        if(firePoint.position.y <= y+0.02 && firePoint.position.y >= y - 0.02)
        {
            if(!isRunning)
                StartCoroutine("shoot");
        }
    }

    IEnumerator shoot()
    {
        isRunning = true;
        yield return new WaitForSeconds(1f);
        GameObject bullet= Instantiate(gObj, firePoint);
        bullet.transform.parent = null;
        isRunning = false;

    }

}
