using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float distanse;
    public float speed;

    private void Update()
    {
        if(PlayerStats.foodCounter <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, PlayerStats.speedOfPlayer * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < PlayerStats.maxY)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + PlayerStats.distanceToJump);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > PlayerStats.minY)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - PlayerStats.distanceToJump);
        }
    }
}
