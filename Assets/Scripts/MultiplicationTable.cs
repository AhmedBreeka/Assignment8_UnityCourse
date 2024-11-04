using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    /*
        Assignment 10: Create a Multiplication Table for 5 (from 1 to 10).

        By: Ahmed Breeka.
    */

    // Start is called before the first frame update
    void Start()
    {
        // ملاحظة انا بدأت جدول الضرب من الصفر عنوة فقط يمكن تغيير قيمة 
        // i = 1
        // للبداية من رقم 1

        for (int i = 0; i <= 10; i++)
        {
            Debug.Log("5 X " + i + " = " +  Multiply(i, 5));
        }
        
    }

    int Multiply(int num1, int num2){
        return num1 * num2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
