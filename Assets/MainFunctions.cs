using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainFunctions : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Start");
    }
    
    private void Awake()
    {
        Debug.Log("Awake");
    }
    
    private void Update()
    {
        Debug.Log("Update");
    }
    
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
}
