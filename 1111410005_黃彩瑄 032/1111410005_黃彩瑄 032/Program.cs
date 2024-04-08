using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111410005_黃彩瑄_032
{
    internal class Program
    {
    static string IntToRoman(int num)
    {
        if (num < 1 || num > 3999)
        {
            return "請輸入介於1到3999之間的整數。";
        }

        string[] romanNumber = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
        int[] number = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };

        string result = "";
        for (int i = 12; i >= 0; i--)
        {
            while (num >= number[i])
            {
                result += romanNumber[i];
                num -= number[i];
            }
        }
        return result;
    }
    
        static void Main(string[] args)
        {

            Console.WriteLine("輸入:");
            int input = int.Parse(Console.ReadLine());
            string output = IntToRoman(input); 
            Console.WriteLine("輸出=" + output); 
            Console.Read();
        }
    }
}
