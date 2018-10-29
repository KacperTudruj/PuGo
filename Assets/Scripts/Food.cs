using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision){
        //if the player has eaten, his Counter food increases
        if (collision.gameObject.tag == GameTags.tagPlayer){

            Destroy(gameObject);
            PlayerStats.foodCounter++;
        }
    }

}
