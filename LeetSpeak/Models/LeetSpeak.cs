using System;
namespace LeetSpeak
{
  public class LeetSpeak
  {
    public static string Translate(string input)
    {

      char[] characterArray = input.ToCharArray();
      for (int i = 0; i < characterArray.Length; i++)
      {
        if (characterArray[i] == 'e') 
        {
          characterArray.SetValue('3', i);
        }
      }
      string output = string.Join("", characterArray);
      return output;
    }
    static void Main()
    {
      Console.WriteLine("tada");
    }
  }
}