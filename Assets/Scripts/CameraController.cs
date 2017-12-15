using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    public float interpVelocity;
    public float minDistance;
    public float followDistance;
    public Vector3 offset;
    Vector3 playerPos;
    bool hasBeenCentered;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerPos = player.transform.position;
        bool hasBeenCentered = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /* float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
         float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
         gameObject.transform.position = new Vector3 (x, y, gameObject.transform.position.z);
         */

        if (player)
        {
            float dist = Vector3.Distance(playerPos, transform.position);

            Vector3 posNoZ = transform.position;
            posNoZ.z = player.transform.position.z;
            if (dist > 0.1)
            {
                hasBeenCentered = false;
                print(dist);
            }
            Vector3 playerDirection = (player.transform.position - posNoZ);
            if (hasBeenCentered == false)
            {
                interpVelocity = playerDirection.magnitude * 10f;
                if (dist < 0.001) hasBeenCentered = true;
            }
            else
            {
                interpVelocity = playerDirection.magnitude * 5f;
            }
            playerPos = transform.position + (playerDirection.normalized * interpVelocity * Time.deltaTime);

            //  if (dist < 0.08 && hasBeenCentered == true)
            //{
            transform.position = Vector3.Lerp(transform.position, playerPos + offset, 0.6f);
            /*  }
              else
              {
                  print("Too far off center");
                  hasBeenCentered = false;
                  transform.position = Vector3.Lerp(transform.position, playerPos + offset, 20.6f);
              }
              dist = Vector3.Distance(playerPos, transform.position);
              if (dist < 0.001 && hasBeenCentered == false)
              {
                  hasBeenCentered = true;

              }*/

        }
    }
}
