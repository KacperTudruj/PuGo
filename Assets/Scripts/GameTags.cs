using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTags : MonoBehaviour {

    public static string tagPlayer;
    public string tagOfPlayer = "Player";

    public static string tagFlore;
    public string tagOfFlore = "Flore";

    public static string tagPlatform;
    public string tagOfPlatform = "Platform";

    // Update is called once per frame
    void Start()
    {

        tagPlayer = tagOfPlayer;
        tagFlore = tagOfFlore;
        tagPlatform = tagOfPlatform;
    }
}
