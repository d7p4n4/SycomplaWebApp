﻿using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SycomplaWebApp
{
    public class GetByIdResponse : Ac4yServiceResponse
    {
        public User User { get; set; }
    }
}
