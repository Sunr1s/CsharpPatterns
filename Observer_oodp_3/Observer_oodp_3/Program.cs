using System;
using Observer_oodp_3.Observer;

namespace Observer_oodp_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var directory = @"C:\Users\admin\Desktop\Новая папка (2)";

            #region FileStatusDelegate
            var fileStatusDelegate = new FileStatusDelegate(directory, new Subscriber("").ItIsSubscriber);

            Console.ReadKey();
            #endregion

            #region FileStatusEvent
            var eventObserver = new FileStatusEvent(directory);
            var subscriber1 = new Subscriber("");
            var subscriber2 = new Subscriber("Second");
            eventObserver.RemoveFiles += subscriber1.ItIsSubscriber;
            eventObserver.RemoveFiles += subscriber2.ItIsSecondSubscriber;

            Console.ReadKey();
            Console.WriteLine("--- Remove second subscriber ---");
            eventObserver.RemoveFiles -= subscriber2.ItIsSecondSubscriber;

            Console.ReadKey();
            #endregion


        }
    }
}
