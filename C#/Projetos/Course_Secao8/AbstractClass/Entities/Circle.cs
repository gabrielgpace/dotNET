﻿using System;
using AbstractClass.Entities.Enum;

namespace AbstractClass.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius , Color color) : base(color)
        {
            
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

