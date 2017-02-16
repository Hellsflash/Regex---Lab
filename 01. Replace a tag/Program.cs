using System;
using System.Text.RegularExpressions;

namespace _01.Replace_a_tag
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input!="end")
            {
                var pattern = @"<a.?href.*?=(.*)>(.*?)<\/a>";

                var replace = @"[URL href=$1]$2[/URL]";

                var repalced = Regex.Replace(input, pattern, replace);

                Console.WriteLine(repalced);

                input = Console.ReadLine();
            }
        }
    }
}
