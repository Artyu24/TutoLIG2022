using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDeath : MonoBehaviour
{
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Other option
        //if (this.transform.position.y <= -6)
        //{
        //    this.transform.position = spawnpoint.position;
        //}
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fall")
        {
            this.transform.position = spawnPoint.position;
        }
    }
}
