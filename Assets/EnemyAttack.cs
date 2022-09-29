using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Attack());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Attack()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
