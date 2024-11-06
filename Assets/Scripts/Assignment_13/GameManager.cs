using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /*
        Assignment 13: Basic Programming in C# (OOP 1).

        By: Ahmed Breeka.
    */

    // Start is called before the first frame update
    void Start()
    {
        Player player1 = new Player();
        player1.InitializePlayer("Ahmed", 90);

        Player player2 = new Player();
        player2.InitializePlayer("Zain", 50);

        // player1
        player1.Heal(5);
        player1.Heal(true);
        
        // player2
        player2.Heal(10);
        player2.Heal(true);

        // show player Count
        Player.ShowPlayerCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
