using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Replace.Models
{
  public class WordReplacer
  {
    public static string LastOutput {get; private set;} = "";

    public static string Replace(string originalSentence, string replacedWord, string newWord)
    {
      string newSentence = Regex.Replace(originalSentence, replacedWord, match =>
      {
        char[] output = newWord.ToCharArray();
        for (int i = 0; i < match.Value.Length && i < output.Length; i++)
        {

          bool isUpper = char.IsUpper(match.Value[i]);
          output[i] = isUpper ? char.ToUpper(output[i]) : char.ToLower(output[i]);
        }
        return new String(output);
      }, RegexOptions.IgnoreCase);
      LastOutput = newSentence;
      return newSentence;
    }
  }
}
