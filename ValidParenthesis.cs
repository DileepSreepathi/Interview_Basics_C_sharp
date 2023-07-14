using System;
using System.Collections.Generic;
namespace exercises
{
    class Program
    {
      //method 1 using stack 
        static void Main(string[] args)
        {
            string text = "<>";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));
            text = "<>()[]{}";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));
            text = "(<>";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));
            text = "[<>()[]{}]";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));
        }
        public static bool test(string s)
        {
            Stack<char> ch = new Stack<char>();
            foreach (var item in s.ToCharArray())
                if (item == '(')
                    ch.Push(')');
                else if (item == '<')
                    ch.Push('>');
                else if (item == '[')
                    ch.Push(']');
                else if (item == '{')
                    ch.Push('}');
                else if (ch.Count == 0 || ch.Pop() != item)
                    return false;

            return ch.Count == 0;
        }
    }
}



//method 2 

using System;
namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "<>";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));
            text = "<>()[]{}";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));
            text = "(<>";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));
            text = "[<>()[]{}]";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));
        }
        public static bool test(string text)
        {
            string temp_text = string.Empty;

            while (text != temp_text)
            {
                temp_text = text;
                text = text.Replace("<>", "").Replace("()", "").Replace("[]", "").Replace("{}", "");
            }

            return text == string.Empty ? true : false;
        }
    }
}
