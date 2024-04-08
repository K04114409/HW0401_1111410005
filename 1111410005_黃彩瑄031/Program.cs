using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111410005_黃彩瑄031
{
    internal class Program
    {
        static List<int> FindWordsWithChar(string[] words, char x)
        {
            List<int> index = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (words[i][j] == x)
                    {
                        index.Add(i);
                        break;
                    }
                }
            }
            return index;
        }

        static void Main(string[] args)
        {
            string[] words = { "leet", "code" };
            char x = 'e';
            List<int> index = FindWordsWithChar(words, x);
            for (int i = 0; i < index.Count; i++)
            {
                int index1 = index[i];
                Console.WriteLine(index1);
            }

            Console.Read();
        }
    }
}

                