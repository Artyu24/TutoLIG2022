using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    private Vector2 startPosition;
    private bool goesRight;
    private Transform playerPosition;
    public float projectileSpeed =1;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        playerPosition = GameObject.Find("Mario").transform;
        if(startPosition.x> playerPosition.position.x)
        {
            goesRight = false;
        }
        else
        {
            goesRight = true;   
        }
        Destroy(this.gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if(goesRight == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * projectileSpeed);
        }
        else
        {
            transform.Translate(Vector3.left * Time.deltaTime * projectileSpeed);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
