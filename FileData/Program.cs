using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            FileDetails details = new FileDetails();
            string value = details.Version(args[1]);
            string version = (args[0].Contains("-v") || args[0].Contains("--v") || (args[0]).Contains("/v")) ? details.Version(args[1]) : string.Empty;
            int size = (args[0].Contains("-s") || args[0].Contains("--s") || (args[0]).Contains("/s")) ? details.Size(args[1]) : 0;
            Console.WriteLine("Responce is:"+ value);            
        }
    }
}
