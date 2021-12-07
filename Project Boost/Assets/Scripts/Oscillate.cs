using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillate : MonoBehaviour
{
    Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
    //[SerializeField] [Range(0,1)] 
    float movementFactor = 0f;
    [SerializeField] float period = 2f; //period of a sin wave, i.e. time for one full cycle of wave

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (period != Mathf.Epsilon) //avoid 'divide by 0' errors - 'Mathf.Epsilon' is more accurate way of comparing float 0 
        {
            float cycles = Time.time / period; //counts number of cycles since game started
            const float tau = Mathf.PI * 2; //sets value for number of radians (there are 2 * pi radians in a circle)
            float rawSinWave = Mathf.Sin(cycles * tau); //calculate sin value for number of radians since start of cycle.
            //this will return value between -1 and 1

            movementFactor = (rawSinWave + 1) / 2; //convert this sin value to number between 0 and 1
            
            Vector3 offset = movementVector * movementFactor;
            transform.position = startingPosition + offset;
        }
    }
}