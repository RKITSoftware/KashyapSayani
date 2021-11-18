using System;

namespace ConsoleAppEventDemo
{
    public delegate void linkToEventHandler();
    class Master
    {
        public string name;
        public Master(string argname)
        {
            name = argname;
        }

        public void eventHandler()
        {
            Console.WriteLine("Notification From {0}",name);
        }
    }
    class Program
    {
        public static event linkToEventHandler evt;
        public static void sendNotification()
        {
            if(evt!=null)
            {
                evt();
            }
        }
        static void Main(string[] args)
        {
            Master objMaster1 = new Master("Object1 Of Master");
            evt += new linkToEventHandler(objMaster1.eventHandler);

            Master objMaster2 = new Master("Object2 Of Master");
            evt += new linkToEventHandler(objMaster2.eventHandler);

            Master objMaster3 = new Master("Object3 Of Master");
            evt += new linkToEventHandler(objMaster3.eventHandler);

            sendNotification();
        }
    }
}