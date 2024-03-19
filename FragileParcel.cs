using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_lab6
{
    public class FragileParcel : Parcel
    {
        private const int BASE_PRICE = 500;

        public FragileParcel(OrientationType orientationType, int weight, string address) : base(orientationType, weight, address)
        {
            if (orientationType==OrientationType.Arbitrary)
            {
                throw new IncorrectOrientiationException(this);
            }
        }

        public override double CalculatePrice(bool fromLocker)
        {
            int price = BASE_PRICE+(weight*2);
            if (fromLocker)
            {
                throw new DeliveryException("Torekeny csomag nem adhato fel ilyen modon!");
            }
            return price;
        }
    }
}
