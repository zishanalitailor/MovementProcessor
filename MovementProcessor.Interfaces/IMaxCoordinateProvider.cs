﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovementProcessor.Domain;

namespace MovementProcessor.Interfaces
{
    public interface IMaxCoordinateProvider
    {
        MaxCoordinate maxCoordinate { get; set; }
    }
}
