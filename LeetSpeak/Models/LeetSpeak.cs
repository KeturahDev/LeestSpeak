using System;
namespace LeetSpeak
{
  public class LeetSpeak
  {
    public static string Translate(string input)
    {

      char[] chars = input.ToCharArray();
      for (int i = 0; i < chars.Length; i++)
      {
        if (chars[i] == 'e') 
        {
          chars.SetValue('3', i);
        }
        if (chars[i] == 't') 
        {
          chars.SetValue('7', i);
        }
        if (chars[i] == 'o') 
        {
          chars.SetValue('0', i);
        }
      if (chars[i] == 'I') 
      {
        chars.SetValue('1', i);
      }
      if (chars[i] == 's') 
      {
        chars.SetValue('z', i);
      }

      }
      string output = string.Join("", chars);
      return output;
    }
    static void Main()
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine(@"    __              __  _____                  __   __
   / /   ___  ___  / /_/ ___/____  ___  ____ _/ /__/ /
  / /   / _ \/ _ \/ __/\__ \/ __ \/ _ \/ __ `/ //_/ / 
 / /___/  __/  __/ /_ ___/ / /_/ /  __/ /_/ / ,< /_/  
/_____/\___/\___/\__//____/ .___/\___/\__,_/_/|_(_)   
                         /_/ ");
      Console.ResetColor();
      Start();
    }
    public static void Start()
    {
      Console.WriteLine("Translate [T] or Exit [E]?");
      string response = Console.ReadLine().ToLower();
      if (response == "t")
      {
        Translating();
      }
      else if (response == "e")
      {
        Console.WriteLine("goodbye!");
      }
    }
    public static void Translating()
    {
      Console.WriteLine("Input anything, and will give it to you in a harder to read format");
      string input = Console.ReadLine();
      string output = Translate(input);

      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine(output);
      Console.ResetColor();
      Start();
    }
  }
}