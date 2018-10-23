using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStartWithUpper()
        {
            // Test that we expect to return true
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
            foreach (var word in words)
            {
                bool result = word.StartWithUpper();
                Assert.IsTrue(result, string.Format("Expected for '{0}': true; actual: {1}", word, result));
            }
        }

        [TestMethod]
        public void TestDoesStartWithUpper()
        {
            // test that we expect to return false
            string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                               "1234", ".", ";", " "};
            foreach (var word in words)
            {
                bool result = word.StartWithUpper();
                Assert.IsFalse(result, string.Format("Expected for '{0}': false; Actual: {1}", word, result));
            }
        }

        [TestMethod]
        public void DirectCallWithNullOrEmpty()
        {
            // Test that we expect to return false
            string[] words = { string.Empty, null };
            foreach (var word in words)
            {
                bool result = StringLibrary.StartWithUpper(word);
                Assert.IsFalse(result, string.Format("Expected for '{0}': false; Actual: {1}", word ?? "<null>", result));
            }
        }
    }
}
