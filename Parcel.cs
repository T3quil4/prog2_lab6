using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_lab6
{
    public abstract class Parcel : IDeliverable, IComparable
    {

        public enum OrientationType
        {
            Arbitrary,
            Horizontal,
            Vertical
        }
        protected OrientationType orientationType;
        public int weight { get; set; }
        public string address { get; set; }

        public OrientationType orientation { get { return this.orientationType; } }
        public abstract double CalculatePrice(bool fromLocker);

        protected Parcel(OrientationType orientationType, int weight, string address)
        {
            this.orientationType = orientationType;
            this.weight = weight;
            this.address = address;
        }

        protected Parcel(int weight, string address)
        {
            this.orientationType=OrientationType.Arbitrary;
            this.weight = weight;
            this.address = address;
        }

        public int CompareTo(object? obj)
        {
            if (obj is IDeliverable)
            {
                IDeliverable? delivarable = obj as IDeliverable;
                if (this.weight == delivarable?.weight)
                {
                    return 0;
                }
                if (this.weight < delivarable?.weight)
                {
                    return 1;
                }
                if (this.weight > delivarable?.weight)
                {
                    return -1;
                }
            }
            return 0;
        }

        public override string ToString()
        {
            return $"Címzett: {this.address} / Tömeg:{this.weight} g\r\n";
        }
    }
}
