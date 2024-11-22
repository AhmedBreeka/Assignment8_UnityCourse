using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace AhmedBreeka.Assigmnment16
{
    public class CharacterTest : MonoBehaviour
    {
        Soldier soldier;
        Officer officer;
        Character[] players = new Character[2];

        // Start is called before the first frame update
        void Start()
        {
            soldier = new Soldier("Solder X", 100, new Position(1f,1f,1f));
            officer = new Officer("Officer Man", 90, new Position(1.5f,1.5f,1.5f));

            players[0] = soldier;
            players[1] = officer;

            for(int i = 0; i < players.Length; i++){
                players[i].DisplayInfo();
                Debug.Log("******************************");
            }

            Debug.Log("------------ Attack ------------");
            Debug.Log("Soldier health before attack : " + players[0].Health);

            players[1].Attack(10, players[0]);
            Debug.Log("Soldier health after attack : " + players[0].Health);

            players[1].Attack(20, players[0], "shooting");
            Debug.Log("Soldier health after shooting attack : " + players[0].Health);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}

