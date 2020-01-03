using System;
using System.Collections.Generic;
using System.Text;

namespace publish_subscribe
{
    public class Subscriber
    {
        public void Subscribe(Publisher pub)
        {
            pub.myEvent += Update;
        }

        public void UnSubscribe(Publisher pub)
        {
            pub.myEvent -= Update;
        }

        public void Update(object sender, MyArgs args)
        {
            Publisher pub =  (Publisher) sender;

            Console.WriteLine(pub.Name + " sent a message: " +args.Message);
        }
    }
}
