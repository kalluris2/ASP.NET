using HelloWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloRemotingService
{ // to make the remotable we need to inherit the class from MarshalByRefObject
    //we neeed to inherit the class from interface so add IhelloRemoteService class library as reference to this class 

    public class HelloRemoteService : MarshalByRefObject, IHelloRemoteService
    {
        public string GetName(string Name)
        {
            return "hello " + Name; 
        }
    }
}
