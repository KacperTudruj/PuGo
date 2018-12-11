using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour 
{
    public GameObject[] platforms;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTimme;
    public float minTime;

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, platforms.Length);
            Instantiate(platforms[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }

}
