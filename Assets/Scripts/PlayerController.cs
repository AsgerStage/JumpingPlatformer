using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public int playerSpeed = 40;
    public bool facingRight = false;
    public int playerJumpPower=100;
    public float moveX;
    private bool hasBeenGrounded;
    public float maxSpeed = 20f;
   
    private void Start()

    {
        Jump();
    }
    // Update is called once per frame
    void Update () {
        playerMove();
	}
    void playerMove()
    {
        //CONTROLS
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && hasBeenGrounded==true)
        {
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

    private void FixedUpdate()
    {
        if (gameObject.GetComponent<Rigidbody2D>().velocity.y > maxSpeed)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, maxSpeed);
        }
    }
    void Jump()
    {
        //JUMPING CODE
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        hasBeenGrounded = false;

    }
    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            hasBeenGrounded = true;
        }
    }
}

