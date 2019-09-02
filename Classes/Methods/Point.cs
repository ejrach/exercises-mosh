using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /*
         * Overloading methods
         */
        //Define method to move this point
        public void Move (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //Overloading the Move method to move this point to a new location
        public void Move(Point newLocation)
        {
            //One way to set the newLocation
            //this.X = newLocation.X;
            //this.Y = newLocation.Y;

            //Or a better way to do it so we only set in one location.
            //But need defensive coding here
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
        }

    }
}
