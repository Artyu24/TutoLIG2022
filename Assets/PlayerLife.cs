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

    // Update is called once per frame
    void Update()
    {
        lifeBar.value = playerLife;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy") {
            playerLife = playerLife - 10;
        }
    }
}
