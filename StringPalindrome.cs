using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Basics_C_sharp
{
    class StringPalindrome
    {
        public void Palindrome()
        {
            string s, revs = "";
            Console.WriteLine(" Enter string");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
            {
                revs += s[i].ToString();
            }
            if (revs == s) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
        }

        //rvers the order of words in the sentence
       // input: Welcome to Csharp corner, output: corner Csharp to Welcome
        internal static void ReverseWordOrder(string str)
        {
            int i;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = str.Length - 1;
            int End = str.Length - 1;

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(str[i]);
            }
            Console.WriteLine(reverseSentence.ToString());
        }


        //reverse the each word in a given string
        //input: Welcome to Csharp corner, output: emocleW ot prahsC renroc
        internal static void ReverseWords(string str)
        {
            StringBuilder output = new StringBuilder();
            List<char> charlist = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || i == str.Length - 1)
                {
                    if (i == str.Length - 1)
                        charlist.Add(str[i]);
                    for (int j = charlist.Count - 1; j >= 0; j--)
                        output.Append(charlist[j]);

                    output.Append(' ');
                    charlist = new List<char>();
                }
                else
                    charlist.Add(str[i]);
            }
            Console.WriteLine(output.ToString());
        }


        //count the occurance of letters in a string 
        internal static void Countcharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }
    }
}
