using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Playerr mario = new Playerr("Mario", 100);
        Enemy hoho = new Enemy("Hoho", 100);

        hoho.Attack(mario, 20);
        Debug.Log("Enemy "+ hoho.Name +" Attacked " + mario.Name);
        Debug.Log("Mario Health = " + mario.Health);

        // healing mario + 10
        mario.Heal(10);
        Debug.Log("Mario Health = " + mario.Health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
