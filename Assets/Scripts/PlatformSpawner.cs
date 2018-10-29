using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour {

    public GameObject platformPrefab;
    Vector3 spawnPosition = new Vector3();
    Vector3 playerPositon = new Vector3();


    private void Start(){
        InvokeRepeating("Spawn", 3f, 1f);
    }

    void Spawn(){
        playerPositon = GameObject.FindGameObjectWithTag("Player").transform.position;
        if(playerPositon.y < -3){
            playerPositon.y = -2;
        }
        if(playerPositon.y > 4){
            playerPositon.y = 2;
        }
        //Debug.Log(playerPositon.y);
        spawnPosition.y = Random.Range( (PlayerStats.minY + playerPositon.y), (PlayerStats.maxY + playerPositon.y));
        spawnPosition.x = 5;
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
    }
}
