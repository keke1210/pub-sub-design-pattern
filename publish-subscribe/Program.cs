using System;

namespace publish_subscribe
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub1 = new Publisher("Publisher1");
            Publisher pub2 = new Publisher("Publisher2");

            Subscriber sub1 = new Subscriber("Subscriber1");
            Subscriber sub2 = new Subscriber("Subscriber2");
            Subscriber sub3 = new Subscriber("Subscriber3");
            Subscriber sub4 = new Subscriber("Subscriber4");

            sub1.Subscribe(pub1);
            sub2.Subscribe(pub1);
            sub3.Subscribe(pub1);

            pub1.Notify("This is first message!");

            sub2.UnSubscribe(pub1);
            pub1.Notify("This is second message without Sub2!");

            sub1.Subscribe(pub2);
            sub4.Subscribe(pub2);
            pub2.Notify("Hello guys te hajdeni te henen!");

            sub2.Subscribe(pub2);
            pub2.Notify($"Sapo na u shtua edhe {sub2.SubscriberName}");
            
            Console.ReadKey();
        }
    }
}
