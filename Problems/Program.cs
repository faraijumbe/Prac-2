using System;
using Problems;
namespace Problems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Prefix("hello");
        }
        public static string Prefix(string input){
            int length = input.Length;
            string [] words = input.Split(" ");
            int numWords = 0;
            foreach(string word in words){
                if(word != "")
                    numWords++;
            }
            string ans = length + "," + numWords + ":" + input;
            return ans;
        }
    }
}
