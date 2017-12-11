using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float xSpeed =  0.1f;
    public float ySpeed = 0.0f;
    private float nextActionTime = 0.0f;
    public float period = 3f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time > nextActionTime)
        {
            nextActionTime += period;

            xSpeed = xSpeed * -1;
            ySpeed = ySpeed * -1;
        }
        transform.Translate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, 0);
    }
}
