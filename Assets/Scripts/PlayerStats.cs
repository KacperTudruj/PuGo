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

    void Start () {
        foodCounter = startFoodCounter;
        JumpPower = jumpPower;
        SpeedOfPlatform = speedOfPlatform;
    }
	
}
