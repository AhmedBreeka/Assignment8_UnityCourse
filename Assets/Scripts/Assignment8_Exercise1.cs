//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //created By Ahmed Breeka
        int number = 0;

        while (number <= 20) 
        {
            number = Random.Range(1, 21);

            if (number == 5) continue;  // if number = 5 skip this value and continue loop
            if (number == 15) break;    // Stop the loop when number = 15
            Debug.Log(number);          // Print number on console unity
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
