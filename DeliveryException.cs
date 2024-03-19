using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace prog2_lab6
{
    public class DeliveryException : Exception
    {
        public DeliveryException()
        {
        }

        public DeliveryException(string? message) : base(message)
        {
        }

        public DeliveryException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DeliveryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
