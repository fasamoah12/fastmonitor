﻿using DataAcess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess.DataModels
{
    public class Stand : IStand
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public Product Product { get; set; }
        public int Duration { get; set; }
        public List<string> CustomerQueue { get; set; }
        public bool OutOfProducts { get; set; } = false;
    }
}
