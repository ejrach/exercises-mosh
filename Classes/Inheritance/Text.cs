using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{

    // The Text class is a child class of the PresentationObject parent class (inheritance)
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {

        }
    }
}
