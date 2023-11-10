using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Alorithms
{
    public class Stack_Class
    {

        string? FilePath;

        public Stack<string> SetupStack()
        {
            FilePath = Utility.FilePath;
            Stack<string> dataStack = new Stack<string>();



            string[] lines = File.ReadAllLines(FilePath);

            // Push each line onto the stack.
            foreach (string line in lines)
            {
                dataStack.Push(line);
            }

            //Stack To Console

            if (dataStack.Count > 0)
            {
                // You can now use the 'data' stack as needed.
                Console.WriteLine("Stack Data from the file:");

                // Pop each line from the stack and print it.
                while (dataStack.Count > 0)
                {
                    string line = dataStack.Pop();
                    Console.WriteLine(line);
                }
            }

            return dataStack;
        }

    }
}
