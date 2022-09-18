using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    private int playerLife = 100;
    public Slider lifeBar;

    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log("Player life = " + playerLife); // Displays player life in console

        lifeBar.value = playerLife;
    }

    private void OnCollisionEnter2D(Collision2D collision) // Enemy damage
    {
        if (collision.gameObject.tag == "enemy")
        {
            playerLife -= 10;
        }
    }
}
