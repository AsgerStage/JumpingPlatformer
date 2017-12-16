using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public Vector3 pos1 = new Vector3();
    public Vector3 pos2 = new Vector3();
    public float speed = 1.0f;
    float eulerx;
    float eulery;
    float eulerz;


    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));

      
        eulerz = transform.eulerAngles.z;
        if (gameObject.CompareTag("toxic")) transform.eulerAngles = new Vector3(0, 0,eulerz+3*Time.deltaTime*100);
    }
}
