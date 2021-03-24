using System;
using System.Collections.Generic;
using System.Text;

namespace F1Model.Models
{
    public class Driver
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public PitCrew PitCrew { get; set; }
        public Constructor Constructor { get; set; }
    }
}
