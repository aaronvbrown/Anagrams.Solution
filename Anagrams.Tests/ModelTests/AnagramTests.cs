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
      AnagramChecker newAnagramChecker = new AnagramChecker("", new List<string> {});
      Assert.AreEqual(typeof(AnagramChecker), newAnagramChecker.GetType());
    }
  }
}
