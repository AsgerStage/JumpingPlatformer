﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public int playerSpeed = 10;
    public bool facingRight = false;
    public int playerJumpPower=125;
    public float moveX;
    
    // Update is called once per frame
    void Update () {
        playerMove();
	}
    void playerMove()
    {
        //CONTROLS
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump")){
            Jump();
        }
        //ANIMATIONS
        //PLAYERDIRECTION
        if(moveX <0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX>0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        //PHYSICS
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

   void Jump()
    {
        //JUMPING CODE
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);

    }
    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}

