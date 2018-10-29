using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public static int foodCounter;
    public int startFoodCounter = 5;

    public static float JumpPower;
    public int jumpPower = 7;

    public static float SpeedOfPlatform;
    public int speedOfPlatform = 1;

    public static float maxY;
    public float maxy = 0.2f;

    public static float minY;
    public float miny = 0.2f;

    public static float timeOfPlatformSpawn;
    public float platormTimerSpawner = 2;

    void Start () {
        foodCounter = startFoodCounter;
        JumpPower = jumpPower;
        SpeedOfPlatform = speedOfPlatform;
        maxY = maxy;
        minY = miny;
        timeOfPlatformSpawn = platormTimerSpawner;
    }
	
}
