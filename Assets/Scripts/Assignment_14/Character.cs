using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
   public string Name{
        set;
        get;
   }

    private int _health = 0;
    public int Health {
        get => _health;
        set{
            if (value > 100)
            {
                _health = 100;
            }
            else if (value < 0)
            {
                _health = 0;
            }
            else
            {
                _health = value;
            }
        }
   }

   public Character(string name, int health){
        Name = name;
        Health = health;
   }
}
