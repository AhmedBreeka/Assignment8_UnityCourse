using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace AhmedBreeka.Assigmnment18.Part2
{
    public class Inventory
    {
        private List<string> _items;

        public Inventory()
        {
            this._items = new List<string>();
        }

        public void AddItem(string item)
        {
            this._items.Add(item);
        }

        public void ShowItems()
        {
            foreach (string item in this._items)
            {
                Debug.Log(item);
            }

            // another way
            // for(int i = 0; i < this._items.Count; i++)
            // {
            //     Debug.Log(this._items[i]);
            // }
        }

        public static Inventory operator +(Inventory item1, Inventory item2)
        {
            Inventory combined = new Inventory();

            combined._items.AddRange(item1._items);
            combined._items.AddRange(item2._items);

            return combined;
        }
    }
}
