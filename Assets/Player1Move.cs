using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMove : MonoBehaviour
{
    Vector2 move;
    int speed = 5;
    int jump = 3;
    Rigidbody2D rb;
    SpriteRenderer sr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Vector2 move = Vector2.zero;

        if (Input.GetKey("a"))
        {
            move.x = -1f; 
            sr.flipX = true;
        }
        else if (Input.GetKey("d"))
        {
            move.x = 1f;
            sr.flipX = false;
        }
        if (Input.GetKey("w"))
        {
            rb.velocity = new Vector2(rb.velocity.x,jump);
        }
        rb.velocity = new Vector2(move.x * speed, rb.velocity.y);


    }

   
}
