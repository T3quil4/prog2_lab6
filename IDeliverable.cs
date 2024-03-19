using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_lab6
{
    public interface IDeliverable
    {
        int weight { get; set; }
        string address { get; set; }
        double CalculatePrice(bool fromLocker);
        int CompareTo(object? obj);
    }
}
