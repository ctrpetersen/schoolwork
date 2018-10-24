using System.Diagnostics;
using CountOccurences;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDUnitTest
{
    [TestClass]
    public class CountCharactersInString
    {
        [TestMethod]
        public void CountOccurencesOfCharacterInStringWith1()
        {
            Assert.AreEqual(1, Counter.CountChars('s', "hejsa"));
        }

        [TestMethod]
        public void CountOccurencesOfCharacterInStringWithMultiple()
        {
            Assert.AreEqual(3, Counter.CountChars('s', "hejsssa"));
        }

        [TestMethod]
        public void CountOccurencesOfCharacterInStringWith1LowerAndUpperCase()
        {
            Assert.AreEqual(1, Counter.CountChars('S', "heSA"));
        }

        [TestMethod]
        public void CountOccurencesOfCharacterInStringWithMultipleLowerAndUpperCase()
        {
            Assert.AreEqual(0, Counter.CountChars('s', null));
        }
    }
}
