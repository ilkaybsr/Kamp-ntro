﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1Tekrar
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitsPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}