using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour 
{

    public GameObject platformPrefab;
    public GameObject foodPrefab;
    public int chanceToSpawnFood = 30;

    Vector3 spawnPosition = new Vector3();
    Vector3 playerPositon = new Vector3();

    private void Start()
    {
        InvokeRepeating("Spawn", 3f, 1f);
    }
    void Spawn()
    {
        // take position from player and spawn platform
        playerPositon = GameObject.FindGameObjectWithTag("Player").transform.position;
        if(playerPositon.y < -2.5f)
        {
            playerPositon.y = -1f;
        }
        if(playerPositon.y > 4)
        {
            playerPositon.y = 2;
        }
        spawnPosition.y = Random.Range( (PlayerStats.minY + playerPositon.y), (PlayerStats.maxY + playerPositon.y));
        spawnPosition.x = 10;
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        
        // spawning food at platform
        if (PlayerStats.chanceOfSpawningFood >= Random.Range(0, 99))
        {

            spawnPosition.y += 1.8f;
            Instantiate(foodPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
