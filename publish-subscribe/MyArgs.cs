using System;
using System.Collections.Generic;
using System.Text;

namespace publish_subscribe
{
    public class MyArgs : EventArgs
    {
        public string Message { get; set; }

        public MyArgs(string message)
        {
            Message = message;
        }

    }
}
