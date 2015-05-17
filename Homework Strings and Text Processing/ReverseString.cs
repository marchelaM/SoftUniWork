using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    static string ReverseStringNum(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
    static void Main(string[] args)
    {
        Console.WriteLine(ReverseStringNum("sample"));
        Console.WriteLine(ReverseStringNum("24tvcoi92"));
    }
}

