using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace prog2_lab6
{
    public class IncorrectOrientiationException : DeliveryException
    {
        private Parcel parcel;
        public IncorrectOrientiationException(Parcel parcel)
        {
            this.parcel = parcel;
        }

        public IncorrectOrientiationException(string? message) : base(message)
        {
        }

        public IncorrectOrientiationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected IncorrectOrientiationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
