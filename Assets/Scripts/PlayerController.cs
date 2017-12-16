using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public int playerSpeed = 40;
    public bool facingRight = false;
    //public int playerJumpPower=100; //outphased
    public float moveX;
    // private bool hasBeenGrounded; //outphased
    public float maxSpeed = 4f;
    private Rigidbody2D rigidbody;
   


    private void Start()

    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.collisionDetectionMode = CollisionDetectionMode2D.Continuous;



    }




    void playerMove()
    {
        //CONTROLS
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButton("Jump"))
        {
            maxSpeed = 6f;
            // Jump();
        }
        else maxSpeed = 4;



        //ANIMATIONS
        //PLAYERDIRECTION
        /*  if(moveX <0.0f && facingRight == false)
          {
              FlipPlayer();
          }
          else if (moveX>0.0f && facingRight == true)
          {
              FlipPlayer();
          }*/
        //PHYSICS
        rigidbody.velocity = new Vector2(moveX * playerSpeed, rigidbody.velocity.y);
        
       
    }

    private void FixedUpdate() 
    {
        playerMove();
        if (rigidbody.velocity.y > maxSpeed)
        {
            rigidbody.velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, maxSpeed);
        }
    }
    /*void Jump()
    {
        //outdated jumping code
        //Unused
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        hasBeenGrounded = false;

    }*/
    /*  void FlipPlayer() //unused
      {
          facingRight = !facingRight;
          Vector2 localScale = gameObject.transform.localScale;
          localScale.x *= -1;
          transform.localScale = localScale;
      }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*  if (collision.gameObject.tag == "Ground")
          {
              hasBeenGrounded = true;
          }*/

        if (collision.gameObject.name == "Wall")  // or if(gameObject.CompareTag("YourWallTag"))
        {
            rigidbody.velocity = Vector2.zero;
        }
    }
}

