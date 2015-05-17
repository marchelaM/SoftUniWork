using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringLength
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string output = string.Empty;
        if (input.Length>20)
        {
            output = input.Substring(0, 20);   
        }
        else
        {
            StringBuilder outputNew = new StringBuilder();
            outputNew.Append(input);
            outputNew.Append('*', 20 - input.Length);
            output = outputNew.ToString();

        }
        Console.WriteLine(output);
    }
}

