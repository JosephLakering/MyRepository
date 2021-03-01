using System;
using System.Text;

namespace OOP_LAB_4
{
    class Program
    {
        static string lowercase(StringBuilder str)
        {
            int num = 0, max, ind = 0;
            string[] s = str.ToString().Split(' ');
            int[] counter = new int[s.Length];
            for (int i = 0; i < str.Length; i++)
            {
                if(Char.IsLower(str[i]))
                {
                    str[i] = Char.ToUpper(str[i]);
                    counter[num]++;
                }
                if(Char.Equals(str[i], ' ')) num++;
            }
            max = counter[0];
            for (int i = 0; i < counter.Length; i++)
                if (counter[i] > max)
                {
                    max = counter[i];
                    ind = i;
                }
            return s[ind];
        }
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            StringBuilder str = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Word, which contains the biggest number of changes is: " + lowercase(str));
            Console.WriteLine("String with applied uppercase: " + str);
        }
    }
}
