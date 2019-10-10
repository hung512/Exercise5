using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(IsUpper(' '));
            Console.Write(IsUpper1(' '));
            Console.Write(IsLower(' '));
            Console.Write(IsLower1(' '));
        }
        public static bool IsUpper(char c)
        {
            for(int i=65;i<90;i++)
            {
                Console.WriteLine(i);
                if (c.Equals(i))
                    return true;
            }
            return false;
        }
        public static bool IsLower(char c)
        {
            for(int i=97;i<122;i++)
            {
                Console.Write(i);
                if (c.Equals(i))
                    return true;
            }
            return false;
        }
        public static bool IsUpper1(char c)
        {
            for(int i=97; i<122;i++)
            {
                Console.WriteLine(i);
                if(c.Equals(i));
                return false;
            }
            return true;
        }
        public static bool IsLower1(char c)
        {
            for(int i=65;i<90;i++)
            {
                Console.WriteLine(i);
                if (c.Equals(i));
                return false;
            }
            return true;
        }
    }
}
