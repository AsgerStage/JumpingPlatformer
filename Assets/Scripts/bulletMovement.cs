using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour {

    public float speed;
    public Vector3 direction;

	void Update () {
        transform.position += direction * Time.deltaTime*speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("enemy") && !other.gameObject.CompareTag("pickUp") && !other.gameObject.CompareTag("toxic"))
            Destroy(gameObject);
    }
}
