using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AhmedBreeka.Assigmnment16
{
    public class Character
    {
       public string name;
       private int _health;
       protected Position position;
       
       public int Health 
       {
            get{ return _health; }
            set{
                if(value < 0) _health = 0;
                else if(value > 100) _health = 100;
                else _health = value;
            }
       }
       public Character(string name, int health, Position position)
       {
            this.name = name;
            this.Health = health;
            this.position = position;
       }
       public Character() :this("No Name", 100, new Position(0,0,0))
       {
       }

       public virtual void DisplayInfo()
       {
            Debug.Log("Character name: " + this.name);
            Debug.Log("Character health: " + this.Health);
            this.position.printPosition();
       }

       public void ApllyDamage(int damage, Character target){
            target.Health -= damage;
       }

       public void Attack(int damage, Character target)
       {
            this.ApllyDamage(damage, target);
       }

       public void Attack(int damage, Character target, string attackType)
       {
            this.ApllyDamage(damage, target);
            Debug.Log("Player " + this.name + " " + attackType + " " + target.name);
       }
    
    }

}

