using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TrueServer_CSharp
{
    public class Server
    {
        public string Name;
        public string Address;
        public int Port;
        public string GameShort;
        public string OS;
    }

    

    class DataManagement
    {

        public Server createServer(String Desc="", String Address="", int Port=0, String GameShort="", String OS="") {
            Server clientServer = new Server();

            clientServer.Name = Desc;
            clientServer.Address = Address;
            clientServer.Port = Port;
            clientServer.GameShort = GameShort;
            clientServer.OS = OS;

            return clientServer;
        }

        

        public String getJSON()
        {

            List<Server> ServerList = new List<Server>();
            ServerList.Add(createServer("Test1", "139.243.89.50", 27015, "csgo", "WIN7ULT"));
            ServerList.Add(createServer("Test2", "139.243.89.50", 27016, "cssource", "DEBIAN8JESS"));

            try
            {

                String ans = JsonConvert.SerializeObject(ServerList);
                return ans;
            } catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return e.ToString();
            }
       
        }

    }
}
