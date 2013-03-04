using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace VideoSite.Web.Common
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class WebException : ApplicationException
    {
        public WebException() { }

        public WebException(string message)
            : base(message)
        {

        }

        public WebException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
        protected WebException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}