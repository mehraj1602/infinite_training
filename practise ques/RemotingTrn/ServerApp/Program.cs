using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;

using Remotinglib;

namespace ServerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////TcpChannel channel = new TcpChannel(8085);
            //HttpChannel channel = new HttpChannel(8085);
            //ChannelServices.RegisterChannel(channel, false);

            //// which object (service) clinent can access remotly

            //RemotingConfiguration.RegisterWellKnownServiceType(
            //    typeof(ServiceClass),// which class u want to register(make the class public)
            //    "Hi",// unique name to be used when  client connect to server
            //    WellKnownObjectMode.Singleton);// single object is used for the client
            //                                   // server creates object for each client



            //Console.WriteLine("Server started... Listening on port 8085");
            //Console.WriteLine("Press ENTER to stop the server.");
            //Console.Read();


            RemotingConfiguration.Configure("Server.config", false);
            // TcpChannel channel = new TcpChannel(8085);
            // ChannelServices.RegisterChannel(channel, false);

            //// which object (service) clinent can access remotly

            // RemotingConfiguration.RegisterWellKnownServiceType(
            //     typeof(ServiceClass),// which class u want to register(make the class public)
            //     "Hi",// unique name to be used when  client connect to server
            //     WellKnownObjectMode.Singleton);// single object is used for the client
            //                 // server creates object for each client



            Console.WriteLine("Server started... Listening on port 8085");
            Console.WriteLine("Press ENTER to stop the server.");
            Console.Read();

        }
    }
    
}
