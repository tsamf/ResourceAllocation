﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication42.Models
{
    public class CreateEvent
    {
        //Event Table
        public string Description { get; set; }
        public int UserID { get; set; }
        public int EventID { get; set; }

        //Event Address Table
        public string street { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
    }
}