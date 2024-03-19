using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_lab6
{
    public class Envelope : IDeliverable
    {
        private string description;
        public int weight { get; set; }
        public string address { get; set; }

        public double CalculatePrice(bool fromLocker)
        {
            if (this.weight<=50)
            {
                return 200;
            }
            if (this.weight <= 500)
            {
                return 400;
            }
            if (this.weight <= 2000)
            {
                return 1000;
            }
            throw new OverweightException();
        }

        public Envelope(string description, int weight, string address)
        {
            this.description = description;
            this.weight = weight;
            this.address = address;
        }

        public override string ToString()
        {
            return $"Címzett: {this.address} / Leírás: {this.description} / Tömeg:{this.weight} g\r\n";
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
