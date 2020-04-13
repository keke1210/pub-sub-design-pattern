using System;
using System.Collections.Generic;
using System.Text;

namespace publish_subscribe
{
    public class Subscriber
    {
        public string SubscriberName { get; set; }
        public Subscriber(string subscriberName)
        {
            SubscriberName = subscriberName;
        }
        public Subscriber()
        { }

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

            Console.WriteLine(pub.Name + " sent a message: '" +args.Message+ "' to subscriber : "+ this.SubscriberName);
        }
    }
}
