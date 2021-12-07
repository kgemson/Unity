using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    void Start()
    {   
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessQuit();
    }

    void ProcessQuit()
    {
        if (Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Q))
        {
            Application.Quit();
            Debug.Log("Quitter");
        }
    }
}