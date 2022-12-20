using System;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(CompressString("aaaabbbcccact"));
            //Console.WriteLine(CompressString("ggaaaaaatttt"));

            int[] arr = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };

            ZeroeToEnd(arr);

            Console.WriteLine(string.Join(",",arr));

        }


        public static string CompressString(string str)
        {
            StringBuilder sb = new StringBuilder();
            int count = 1;

            for (int i = 0;  i < str.Length; i++)
            {
                if (i + 1  <  str.Length && str[i] == str [i + 1]){
                    count++;
                }
                else
                {
                    sb.Append(str[i]);
                    sb.Append(count);
                    count = 1;
                }
            }

            return sb.ToString();
        }

        public static void ZeroeToEnd(int[] num)
        {
            int nonZero = 0;

            for(int i=0; i < num.Length; i++)
            {
                if(num[i] != 0)
                {
                    num[nonZero++] = num[i];
                }
            }

            for(int i = nonZero; i < num.Length; i++)
            {
                num[i] = 0;
            }
        }

    }
}


/*1. COMPRESS A STRING
Given a string e.g aaaabbbcccac compress the string to show the consecutive count of each
character.
E.g
aaaabbbcccact; returns  a4b3c3a1c1; 
ggaaaaaatttt returns g2a6t4*/

/*Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
Input => {1, 2, 0, 1, 0, 1, 0, 3, 0, 1} output => {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}*/