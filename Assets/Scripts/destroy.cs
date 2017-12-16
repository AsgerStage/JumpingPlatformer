using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("active");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator active()
    {

        yield return new WaitForSeconds(5f);
        Destroy(gameObject);

    }
}
