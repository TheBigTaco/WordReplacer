using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Replace.Models;

namespace Replace.Tests
{
  [TestClass]
  public class WordReplacerTest
  {
    [TestMethod]
    public void Replace_WillReplaceWordsInSentence_String()
    {
      string oldSentence = "This is new sentence";
      string replacedWord = "is";
      string newWord = "ar";
      string newSentence = "Thar ar new sentence";

      Assert.AreEqual(newSentence, WordReplacer.Replace(oldSentence, replacedWord, newWord));
    }

    [TestMethod]
    public void Replace_WordsAreAllCaps_String()
    {
      string oldSentence = "THIS IS NEW SENTENCE";
      string replacedWord = "is";
      string newWord = "ar";
      string newSentence = "THAR AR NEW SENTENCE";

      Assert.AreEqual(newSentence, WordReplacer.Replace(oldSentence, replacedWord, newWord));
    }

    [TestMethod]
    public void Replace_WordsStartWithCaps_String()
    {
      string oldSentence = "This Is New Sentence";
      string replacedWord = "is";
      string newWord = "ar";
      string newSentence = "Thar Ar New Sentence";

      Assert.AreEqual(newSentence, WordReplacer.Replace(oldSentence, replacedWord, newWord));
    }

    [TestMethod]
    public void Replace_WordsAreWeirdCase_String()
    {
      string oldSentence = "ThIs iS sI wIsisISis";
      string replacedWord = "is";
      string newWord = "ar";
      string newSentence = "ThAr aR sI wArarARar";

      Assert.AreEqual(newSentence, WordReplacer.Replace(oldSentence, replacedWord, newWord));
    }

    [TestMethod]
    public void Replace_SentenceWithPunctuation_String()
    {
      string oldSentence = "This, is? new... sentence! i.s.";
      string replacedWord = "is";
      string newWord = "ar";
      string newSentence = "Thar, ar? new... sentence! i.s.";

      Assert.AreEqual(newSentence, WordReplacer.Replace(oldSentence, replacedWord, newWord));
    }
  }
}
