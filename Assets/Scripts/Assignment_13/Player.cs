using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    /*
        Assignment 13: Basic Programming in C# (OOP 1).

        By: Ahmed Breeka.
    */
    
    public string playerName;
    public int helth;

    public static int playerCount = 0;

    public void InitializePlayer(string name, int initialHealth){
        playerName = name;
        helth = initialHealth;

        playerCount++;
    }

    public void Heal(int amount){
        helth += amount;
        Debug.Log(helth); 
    }

    public void Heal(bool fullRestore){
        if (fullRestore == true) helth = 100 ;
        Debug.Log(helth); 
    }

    public static void ShowPlayerCount(){
        Debug.Log(playerCount);
    }
}
