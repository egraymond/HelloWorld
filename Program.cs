using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Type anything you want! By default, the input will be 'Hello World!': ");
        string phrase = Console.ReadLine();
        if (phrase == "")
        {
            phrase = "Hello World!";
        }

        CombineSeparatedLetters(phrase);
    }
    
    public static void CombineSeparatedLetters(string word)
    {

        for (int i = 0; i <= word.Length; i++)
        {
            // ChatGPT used substrings to accomplish this task without creating a list. Seems like the most effective way. 
            string substring = word.Substring(0, i);
            Console.WriteLine(substring);
        }
    }
}