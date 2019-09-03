﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }

        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }

        public bool IsShipped
        {
            get { return Shipment != null; }
        }

    }
}
