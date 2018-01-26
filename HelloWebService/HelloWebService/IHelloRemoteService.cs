using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWebService
{
    public interface IHelloRemoteService
    {
        string GetName(string Name);
    }
}
