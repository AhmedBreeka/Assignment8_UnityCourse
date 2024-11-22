using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AhmedBreeka.Assigmnment16
{
    public struct Position
    {
        public float X;
        public float Y;
        public float Z;

        public Position(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public void printPosition()
        {
            Debug.Log("The position: (X = " + this.X + ", Y = " + this.Y + ", Z = " + this.Z + ")");
        }

    }

}

