using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            //When we iterate through the shapes in this list, we just call the shapes' Draw method
            //which its behavior is different depending on its shape. This is polymorphism
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
