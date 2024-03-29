﻿using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    class Program
    {

        //Overriding is modifying the implementation of an inherited method
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();

            //shapes.Add(new Shape { Width = 100, Height = 100, Type = ShapeType.Circle });
            //shapes.Add(new Shape { Width = 100, Height = 30, Type = ShapeType.Rectangle });

            //The above now becomes:
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());


            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

        }
    }
}
