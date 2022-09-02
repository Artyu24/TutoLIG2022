using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    private bool isGrounded;

    private int compteur;
    public Text compteurText;

    void Start()
    {


    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.position = transform.position + horizontalInput * Vector3.right * Time.deltaTime * speed;

        if(isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
                rb.AddForce(Vector2.up * jumpForce);
                isGrounded = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.tag == "Coin")
        {
            compteur++;
            compteurText.text = compteur.ToString();
            Destroy(collision.gameObject);
        }
        else
        {
            isGrounded = true;
        }
    }
}
