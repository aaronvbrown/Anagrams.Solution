
using System;
using System.Collections.Generic;

namespace Anagrams.Models
{
  public class AnagramChecker
  {
    public string firstWord;

    public List<string> wordList = new List<string> {};

    public AnagramChecker(string frstWrd, List<string> wrdLst)
    {
      firstWord = frstWrd;
      wordList = wrdLst;
    }
  }
}
