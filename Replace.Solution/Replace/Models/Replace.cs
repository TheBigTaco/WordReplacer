using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Replace.Models
{
  public class WordReplacer
  {
    public static string Replacer(string originalSentence, string replacedWord, string newWord)
    {
      //Regex regex = new Regex($@"{replacedWord}", RegexOptions.IgnoreCase);
      string newSentence = Regex.Replace(originalSentence, replacedWord, match =>
      {
        char[] output = newWord.ToCharArray();
        for (int i = 0; i < match.Value.Length; i++)
        {
          bool isUpper = char.IsUpper(match.Value[i]);
          output[i] = isUpper ? char.ToUpper(output[i]) : char.ToLower(output[i]);
        }
        return new String(output);
      }, RegexOptions.IgnoreCase);
      return newSentence;
    }
  }
}
