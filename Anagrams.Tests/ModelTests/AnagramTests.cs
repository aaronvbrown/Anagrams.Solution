using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams.Models;

namespace Anagrams.Tests 
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void AnagramConstructor_CreateInstanceOfAnagramChecker_AnagramChecker()
    {
      AnagramChecker newAnagramChecker = new AnagramChecker("bat", new List<string> {"boat", "coat"});
      Assert.AreEqual(typeof(AnagramChecker), newAnagramChecker.GetType());
    }

    [TestMethod]
    public void AnagramGet_ReturnWord_String()
    {
      AnagramChecker newAnagramChecker = new AnagramChecker("bat", new List<string> {"boat", "coat"});
      Assert.AreEqual("bat", newAnagramChecker.FirstWord);
    }
    [TestMethod]
    public void AnagramListGet_ReturnList_List()
    {
      AnagramChecker newAnagramChecker = new AnagramChecker("bat", new List<string> {"boat", "coat"});
      List<string> newList = new List<string> {"boat", "coat"};
      CollectionAssert.AreEqual(newList, newAnagramChecker.WordList);
    }

    [TestMethod]
    public void IsAnagram_ReturnsListOfAnagrams_List()
    {
      AnagramChecker newAnagramChecker = new AnagramChecker("bat", new List<string> {"boat", "coat", "tab"});
      Assert.AreEqual(typeof(List<string>), newAnagramChecker.IsAnagram().GetType());
    }

  }
}
