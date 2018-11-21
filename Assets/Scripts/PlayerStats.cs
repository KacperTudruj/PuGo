using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour 
{
    [Header("Player stats: ")]
    public static int foodCounter;
    int startFoodCounter = 5;

    public static float jumpPower;
    public int JumpPower = 7;
    [Header("Platform and food stats: ")]

    public static float SpeedOfPlatform;
    public int speedOfPlatform = 1;

    [Header("Spawning platofrm terms of player positions: ")]
    public static float maxY;
    public float maxy = 0.2f;

    public static float minY;
    public float miny = 0.2f;

    public static float timeOfPlatformSpawn;
    public float platormTimerSpawner = 2;

    public static int chanceOfSpawningFood;
    public int chanceToSpawnFood = 30;

    void Start () {
        foodCounter = startFoodCounter;
        jumpPower = JumpPower;
        SpeedOfPlatform = speedOfPlatform;
        maxY = maxy;
        minY = miny;
        timeOfPlatformSpawn = platormTimerSpawner;
        chanceOfSpawningFood = chanceToSpawnFood;
    }
	
}
