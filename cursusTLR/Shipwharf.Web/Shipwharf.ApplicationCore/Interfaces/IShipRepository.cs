﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shipwharf.ApplicationCore.Entities;

namespace Shipwharf.ApplicationCore.Interfaces
{
    public interface IShipRepository
    {
        public Task<Ship> CreateShipAsync(Ship ship);

    }
}
