using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health) : base(name, health) {}

    public void Attack(Playerr player, int damage)
    {
        if( player.Health == 0){
            Debug.Log("The Player " + player.Name + " is dead");
        }
        else{
            player.Health = player.Health - damage;
        }
        
    }
}
