using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Alorithms
{
    public class Array_Class
    {
        string? FilePath;

        public void SetupArray()
        {
            FilePath = Utility.FilePath;
            //Array
            string[] data = ReadTextFileToArray(FilePath);


            static string[] ReadTextFileToArray(string FilePath)
            {
                string[] dataArray = null;
                // Read all lines from the specified text file and store them in an array.
                dataArray = File.ReadAllLines(FilePath);
                return dataArray;
            }


            if (data != null)
            {
                // You can now use the 'data' array as needed.
                Console.WriteLine("Array Data from the file:");

                foreach (string line in data)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
