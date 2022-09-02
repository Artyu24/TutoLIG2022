using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class PieceTest : MonoBehaviour
{
    private int piece;
    public Text compteur;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            piece++;
            compteur.text = piece.ToString();
            Destroy(collision.gameObject);
        }
    }
}
