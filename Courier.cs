using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog2_lab6
{
    public class Courier
    {
        private IDeliverable[] deliverables;
        private int sumOfWeight;
        public int sumOfWeights { get { return this.sumOfWeight; } }

        public Courier(int deliverablesSize)
        {
            this.deliverables = new IDeliverable[deliverablesSize];
        }

        public void PickUpItem(IDeliverable item)
        {
            int i = 0;
            while (i<this.deliverables.Length && this.deliverables[i]!=null)
            {
                ++i;
            }

            if (i<this.deliverables.Length)
            {
                this.deliverables[i] = item;
                this.sumOfWeight += item.weight;
                return;
            }

            throw new DeliveryException();
        }

        public IDeliverable[] FragilesSorted()
        {
            IDeliverable[] sortedResult = new IDeliverable[this.deliverables.Length];

            for (int i = 0; i < this.deliverables.Length; ++i)
            {
                if (this.deliverables[i] is FragileParcel)
                {
                    sortedResult[i] = this.deliverables[i];
                }
            }

            Array.Sort(sortedResult);

            return sortedResult;
        }
    }
}
