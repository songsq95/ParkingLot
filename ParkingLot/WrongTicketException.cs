﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class WrongTicketException : Exception
    {
        public WrongTicketException(string message) : base(message)
        {
        }
    }
}
