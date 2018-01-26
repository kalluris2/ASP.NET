using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using HelloRemotingService;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           HelloRemoteService service = new HelloRemoteService();
            TcpChannel chanel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(chanel);
        }
    }
}
