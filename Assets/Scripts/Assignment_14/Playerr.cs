using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerr : Character
{
    public Playerr(string name, int health) : base(name, health) {}

   public void Heal(int amount){
    Health += amount;
   }
}
