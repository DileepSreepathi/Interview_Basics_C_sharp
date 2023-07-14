public class StrOperator
{
    static void Main()
    {
        string str = "Hello How are you";
        string[] split=str.Split(' ');
        Array.Reverse(split);
        Console.WriteLine(split);
        for (int i = 0; i <= split.Length - 1; i++)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(split[i] + "" + ' ');
            Console.WriteLine("\n");
        }

        //using in single line
        string result = string.Join(" ", str.Split(' ').Reverse());
        var reversedWords = string.Join(" ",

      result.Split(' ')
         .Select(x => new String(x.Reverse().ToArray())));

        Console.WriteLine(result+" |");
        Console.WriteLine(reversedWords);

        ////////////using without any lib here
        //string str = "I am going to reverse myself.";
        //string strrev = "";

        //foreach (var word in str.Split(' '))
        //{
        //    string temp = "";
        //    foreach (var ch in word.ToCharArray())
        //    {
        //        temp = ch + temp;
        //    }
        //    strrev = strrev + temp + "";
        //}
        //Console.WriteLine(strrev);
    }
}
