using System;

namespace SingleTone
{
    class Program
    {
        static TableServer host1list=TableServer.GetTableServer(); /*= new TableServer();*/
        static TableServer host2list=TableServer.GetTableServer(); /*= new TableServer();*/
        static void Main(string[] args)
        {
            TableServer servers=TableServer.GetTableServer(); /*= new TableServer();*/
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine("The next server is:" + servers.GetNextServer
                host1listnextserver();
                host2listnextserver();
            }
            Console.ReadLine();
        }
        private static void host1listnextserver()
        {
            Console.WriteLine("The next server is:" + host1list.GetNextServer());
        }
        private static void host2listnextserver()
        {
            Console.WriteLine("The next server is:" + host2list.GetNextServer());
        }
    }
}
