using System;
using System.Collections.Generic;
using System.Text;
using ProductStatistics.Core.Interfaces;

namespace ProductStatistics.Core.Implementation
{
    abstract class Command 
    {
        public string[] Data { get; set; }
        protected Command(string[] data)
        {
            Data = data;
        }
        public abstract void execute(Restourant restourant);
    }
}
