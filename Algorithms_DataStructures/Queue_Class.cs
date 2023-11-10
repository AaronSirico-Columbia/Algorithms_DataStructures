using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Alorithms
{
    public class Queue_Class
    {
        string? FilePath;

        public Queue<string> SetupQueue()
        {
            FilePath = Utility.FilePath;

            //Queue
            // Specify the path to the text file you want to read.

            Queue<string> dataQueue = new Queue<string>();

            // Read all lines from the specified text file and store them in an array.
            string[] lines = File.ReadAllLines(FilePath);

            // Enqueue each line into the queue.
            foreach (string line in lines)
            {
                dataQueue.Enqueue(line);
            }



            //Queue To Console

            if (dataQueue.Count > 0)
            {
                // You can now use the 'data' queue as needed.
                Console.WriteLine("Queue Data from the file (in the order it was read):");

                foreach (string line in dataQueue)
                {
                    Console.WriteLine(line);
                }
            }

            return dataQueue;

        }


    }
}
