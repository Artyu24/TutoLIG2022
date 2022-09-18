using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto2022Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform groundCheck;

    public LayerMask collisionLayers;

    public bool grounded;
    public bool canMove;

    private Vector2 velocity = Vector3.zero;

    public float speed;
    public float jumpForce;
    public float groundCheckRadius;

    public Animator animatorUI;

    private void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, collisionLayers);
    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove) return;
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime, rb.velocity.y);
        rb.velocity = Vector2.SmoothDamp(rb.velocity, direction, ref velocity, .05f);
        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    public void Death()
    {
        canMove = false;
        animatorUI.SetTrigger("Death");
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}
