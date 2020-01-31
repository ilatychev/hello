using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class Circle
    {
        private int radius;

        public Circle()
        {
            radius = 1;
        }

        public Circle(int newRadius)
        {
            radius = newRadius;
        }

        public int GetRadius()
        {
            return radius;
        }

        public void SetRadius(int newRadius)
        {
            radius = newRadius;
        }

        public double GetCircumference()
        {
            int diameter = radius * 2;
            return 3.14 * diameter;
        }

        public double GetArea()
        {
            int radiusSquared = radius * radius;
            return 3.14 * radiusSquared;
        }
    }
}