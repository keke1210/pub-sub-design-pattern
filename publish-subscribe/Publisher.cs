using System;
using System.Collections.Generic;
using System.Text;

namespace publish_subscribe
{
    public class Publisher
    {
        public string Name { get; set; }

        public event EventHandler<MyArgs> myEvent;

        public void Notify(string message)
        {
            if(myEvent != null)
            {
                myEvent(this, new MyArgs(message));
            }
        }

    }
}
