using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Alorithms
{
    public class Dictionary_Class
    {
        string? FilePath;

        public void SetUpDictionary()
        {
            FilePath = Utility.FilePath;
            //Dictionary
            Dictionary<string, string> dataDictionary = new Dictionary<string, string>();

            string[] lines = File.ReadAllLines(FilePath);


            foreach (string line in lines)
            {
                // Split each line into key and value using a delimiter (e.g., ':').
                string[] parts = line.Split(' ');
                string key = parts[0];
                string value = parts[1];
                // Add the key-value pair to the dictionary.
                dataDictionary[key] = value;
            }

            //Dictionary To Console
            foreach (var kvp in dataDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}
