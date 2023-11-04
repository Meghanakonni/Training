using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Lifetime;

namespace RemotingServer
{
    //service class
    public class Service : MarshalByRefObject
    {
        public int HighestNumber(int n1, int n2)
        {
            int maxnumber = (Math.Max(n1, n2));            
            return maxnumber;
        }
        public int SmallestNumber(int n1, int n2)
        {
            int minnumber = (Math.Min(n1, n2));            
            return minnumber;
        }
        public long Product(int n1, int n2)
        {
            long product = (Math.BigMul(n1, n2));           
            return product;
        }

        public double Remainder(int n1, int n2)
        {
            double rem = (Math.IEEERemainder(n1, n2));
            return rem;
        }
    }
    //server class
    //it hosts the services by registering them
    class Server
    {
        static void Main(string[] args)
        {
            TcpChannel tcpchannel = new TcpChannel(8089);
            //register the channel
            ChannelServices.RegisterChannel(tcpchannel, false);

            //configure all known services
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Service), "OurFirstRemoteService",
                WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Services started on tcp Port No: 8089...");
            Console.WriteLine("Press any Key to Stop the Server Services..");
            Console.ReadLine();
        }
    }
}