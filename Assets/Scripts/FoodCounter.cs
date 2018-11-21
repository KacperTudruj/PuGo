using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodCounter : MonoBehaviour {

    public Text foodText;
	
	void Update () 
    {
        foodText.text = PlayerStats.foodCounter.ToString();		
	}
}
