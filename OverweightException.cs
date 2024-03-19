using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace prog2_lab6
{
    public class OverweightException : Exception
    {
        public OverweightException()
        {
        }

        public OverweightException(string? message) : base(message)
        {
        }

        public OverweightException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected OverweightException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
