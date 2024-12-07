using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AhmedBreeka.Assigmnment18.Part1
{
    public class GenericsTest : MonoBehaviour
    {
        // Start is called before the first frame update

        GameContainer<string> item;
        GameContainer<string> item2;

        void Start()
        {
            item = new GameContainer<string>();
            item.SetItem("Healing Potion");
            
            Debug.Log("Stored item: " + item.GetItem());

            Debug.Log(GameUtils.DescribeItem(item.GetItem()));

            // using set and get
            item2 = new GameContainer<string>();
            item2.Item = "Healing Potion 2";
            Debug.Log("Stored item2: " + item2.Item);
            Debug.Log(GameUtils.DescribeItem(item2.Item));
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
