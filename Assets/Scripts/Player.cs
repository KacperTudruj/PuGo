﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool grounded = true;
    private Rigidbody2D rb2d;
    private bool doublejump = true;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        jump();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if player hit ground, you can jump agine (can't jump in air)
        if (collision.gameObject.tag == GameTags.tagFlore || collision.gameObject.tag == GameTags.tagPlatform)
            grounded = true;
    }
    private void jump()
    {
        if (grounded)
        {
            //If the player hit the "ground" can jump
            if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
            {
                rb2d.velocity = new Vector2(0, PlayerStats.jumpPower);
                grounded = false;
                doublejump = true;
            }
        }
        else
        {
            //If the player has a "Food Counter", can jump agine
            nextJump();
        }
    }
    private void nextJump()
    {
        if (doublejump)
        {
            if (PlayerStats.foodCounter > 0)
            {
                if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
                {
                    rb2d.velocity = new Vector2(0, PlayerStats.jumpPower);
                    PlayerStats.foodCounter--;
                    doublejump = false;
                }
            }
        }
    }
}
