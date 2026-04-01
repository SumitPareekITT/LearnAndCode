using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileStream file = null;

        try
        {
            file = new FileStream("test.txt", FileMode.OpenOrCreate);
            Console.WriteLine("File opened successfully");

            throw new Exception("Something went wrong");
        }
        finally
        {
            if (file != null)
            {
                file.Close();
                Console.WriteLine("File closed in finally block");
            }
        }
    }
}