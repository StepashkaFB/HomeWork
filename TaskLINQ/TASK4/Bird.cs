﻿using System;

namespace TASK4
{
    class Bird : IAnimalInZoo
    {
        public string Name { get; set; }
        public bool Fly { get; set; }
        public bool Walk { get; set; }
        public string Color { get; set; }
    }
}