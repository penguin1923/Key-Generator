using CD_Key_Generator.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using Prometheus;

namespace CD_Key_Generator
{
    public class Program
    {
        private static readonly Counter TickTock =
       Metrics.CreateCounter("Cdup", "Just keeps on ticking");

        static void Main(string[] args)
        {
            
            Menu menu = new Menu();
            var server = new MetricServer(hostname: "localhost", port: 1234);
            server.Start();
            TickTock.Inc();
            menu.MainMenu();
        }

    }
}
