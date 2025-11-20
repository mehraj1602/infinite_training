using RemotingTrn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // an application who wants to consume the service

            RemotingConfiguration.Configure("Client.config", false);

            // Get all registered client types
            var entries = RemotingConfiguration.GetRegisteredWellKnownClientTypes();

            if (entries.Length == 0)
            {
                Console.WriteLine("No client types registered in config.");
                return;
            }

            // Use the registered URL from config
            var remoteType = entries[0];// read the first data  
            IMyinter ob = (IMyinter)Activator.GetObject(remoteType.ObjectType, remoteType.ObjectUrl);

            ////TcpChannel channel = new TcpChannel();// i want to communicate using binary format
            //HttpChannel channel = new HttpChannel();
            //ChannelServices.RegisterChannel(channel, false);// register the the path, no security

            //// Connect to remote object
            //IMyinter ob = (IMyinter)Activator.GetObject(
            //    typeof(IMyinter),
            //    "http://localhost:8085/Hi");

            Console.WriteLine("Connected to remote object...");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            string result = ob.Show(name);
            Console.WriteLine(result);


            Console.Read();
        }
    }
}
