﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovementProcessor.Domain.Helper;

namespace MovementProcessor.Domain
{
    public class Robot
    {
        public int x { get; set; }
        public int y { get; set; }
        public Direction DirectionOfMovement { get; set; } 
    } 
}
