using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour 
{
    //private Rigidbody2D rb2d;

    void Start () 
    {
        //rb2d = GetComponent<Rigidbody2D>();
    }
	void Update () 
    {
        transform.Translate(Vector2.left * PlayerStats.speedOfPlatform * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //player takes damge
            PlayerStats.foodCounter -= 1;
            Destroy(gameObject);
        }
        if (collision.CompareTag("Flore"))
        {
            Destroy(gameObject);
        }
    }
    
}
