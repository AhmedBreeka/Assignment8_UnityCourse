using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AhmedBreeka.Assigmnment18.Part1
{
    public class GameContainer<T>
    {
        private T _item;
        public void SetItem(T item)
        {
            this._item = item;
        }

        public T GetItem()
        {
            return this._item;
        }

        // using set ang get
        public T Item{
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }
    }
}

