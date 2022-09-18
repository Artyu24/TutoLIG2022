using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{

    public float speed = 5.5f; //valeur de vitesse

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q)) //Quand on appuie sur la touche
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }  //Position +=(on ajoute) Vecteur Gauche x Vitesse x Temps entre chaques frames

        if (Input.GetKey(KeyCode.D)) // Quand on appuie sur l'autre touche
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }  //Même chose que ligne 22 mais à Droite ptit con ;)
    }

}
