using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    int nombreEntier = 26;
    float nombreDecimal = 23.7f;
    string chaineDeCaracteres = "LéoIndieGames";

    bool booleen = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(booleen == false)
        {
            //faire quelque chose
        }
        else if (nombreDecimal < 23)
        {
            //faire autre chose
        }
        else
        {
            //faire autre chose
        }
    }
}
