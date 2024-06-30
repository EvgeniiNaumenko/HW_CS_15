using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_15_28_06_2024
{
    internal class IPInfo
    {
        public string ip {  get; set; }
        public string continent { get; set; }
        public string country { get; set; } 
        public string city { get; set; }
        public override string ToString()
        {
            return $"IP:{ip}\nContinent: {continent}\nCountry: {country}\nCity: {city}";
        }
    }
}
