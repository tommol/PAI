using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pl.lodz.p.ftims.edu.pai.central.Exceptions
{

    [Serializable]
    public class CannotDeleteEmployeeException : Exception
    {
        public CannotDeleteEmployeeException() { }
        public CannotDeleteEmployeeException(string message) : base(message) { }
        public CannotDeleteEmployeeException(string message, Exception inner) : base(message, inner) { }
        protected CannotDeleteEmployeeException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}