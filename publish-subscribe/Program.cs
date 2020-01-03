using System;

namespace publish_subscribe
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher pub1 = new Publisher();
            pub1.Name = "Pub1";

            Subscriber sub1 = new Subscriber();
            Subscriber sub2 = new Subscriber();
            Subscriber sub3 = new Subscriber();

            sub1.Subscribe(pub1);
            sub2.Subscribe(pub1);
            sub3.Subscribe(pub1);

            pub1.Notify("This is first message!");

            sub2.UnSubscribe(pub1);
            pub1.Notify("This is second message without Sub2!");


            Console.ReadKey();
        }
    }
}
