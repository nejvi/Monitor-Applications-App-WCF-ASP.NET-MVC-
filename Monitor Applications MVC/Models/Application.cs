﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitorApplicationsMVC.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string monitorModel { get; set; }
        public double price { get; set; }

    }
}
