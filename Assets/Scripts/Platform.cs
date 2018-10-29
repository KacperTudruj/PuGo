﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    private Rigidbody2D rb2d;


    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        rb2d.velocity = new Vector2(-PlayerStats.SpeedOfPlatform, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == GameTags.tagEnd){

            Destroy(gameObject);
            Debug.Log("DUPA");
        }
    }
}
