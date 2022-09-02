using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class PlayerTest : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    private int piece;
    public Text compteur;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.position = transform.position + horizontalInput * Vector3.right * Time.deltaTime * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(jumpForce * Vector2.up);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            piece++;
            compteur.text = piece.ToString();
            Destroy(collision.gameObject);
        }
    }

}
