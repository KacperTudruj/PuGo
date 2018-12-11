using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour 
{
    [Header("Player stats: ")]
    public static int foodCounter;
    int startFoodCounter = 5;

    public static int speedOfPlayer;
    public int SpeedOfPlayer;

    public static int distanceToJump;
    public int DistanceToJump;

    public static float maxY;
    public float maxy = 0.2f;

    public static float minY;
    public float miny = 0.2f;

    [Header("Platform stats: ")]
    public static int speedOfPlatform;
    public int SpeedOfPlatform;


    public static int chanceOfSpawningFood;
    public int ChanceOfSpawningFood;

    void Start () {
        foodCounter = startFoodCounter;
        speedOfPlayer = SpeedOfPlayer;
        distanceToJump = DistanceToJump;
        maxY = maxy;
        minY = miny;


        chanceOfSpawningFood = ChanceOfSpawningFood;
        speedOfPlatform = SpeedOfPlatform;
    }
	
}
