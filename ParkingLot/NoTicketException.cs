﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class NoTicketException : Exception
    {
        public NoTicketException(string message) : base(message)
        {
        }
    }
}
