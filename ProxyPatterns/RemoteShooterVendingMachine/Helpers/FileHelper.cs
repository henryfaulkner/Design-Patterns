using System.Collections.Generic;
using System.IO;
using System;

namespace RemoteShooterVendingMachine
{
    public class FileHelper
    {
        public static Dictionary<string, string> ParseFileForKeyValuePairs(string location)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            using (StreamReader reader = new StreamReader($"Data/{location}.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    dict.Add(parts[0], parts[1]);
                    Console.WriteLine($"{parts[0]}:{parts[1]}");
                }
            }

            return dict;
        }
    }
}