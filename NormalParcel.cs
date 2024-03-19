using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_lab6
{
    internal class NormalParcel : Parcel
    {
        private static Random rand = new Random();
        private const int BASE_PRICE = 500;
        public NormalParcel(int weight, string address) : base(weight, address)
        {
            orientationType = (OrientationType)rand.Next(0,3);
            this.weight = weight;
            this.address = address;
        }

        public override double CalculatePrice(bool fromLocker)
        {
            int price = BASE_PRICE+weight;

            if (fromLocker)
            {
                price -= 250;
            }
            
            return price;
        }
    }
}
