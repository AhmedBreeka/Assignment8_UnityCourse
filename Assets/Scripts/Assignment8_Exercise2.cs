using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Exercise 2: Funny Sentence Generator:
        // By : Ahmed Breeka
        //Cat, Dog, Car, Pizza, Hat, Fish, Tree, Monkey, Ball, Bird.

        string[] words = { "Cat", " Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };

        string funnySentence = "";

        int i = 0;
        while (i < 7)
        {
            funnySentence += words[Random.Range(i, words.Length)] + " ";
            i++;
        }

        Debug.Log(funnySentence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
