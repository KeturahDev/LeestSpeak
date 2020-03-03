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

      }
      string output = string.Join("", chars);
      return output;
    }
    static void Main()
    {
      Console.WriteLine("tada");
    }
  }
}