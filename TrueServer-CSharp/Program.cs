﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TrueServer_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataManagement dm = new DataManagement();
            String Servers_json  = dm.getJSON();
            Console.WriteLine(Servers_json);

            Console.Read();
        }
    }
}
