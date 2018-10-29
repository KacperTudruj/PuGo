﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour {

    public GameObject platformPrefab;

    public int numberOfPlatforms;
    public float minY = .2f;
    public float maxY = 1.5f;

    private void Start(){

        Vector3 spawnPosition = new Vector3();

        for(int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    void Update () {

		
	}
}
