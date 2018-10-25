using System;
using Xunit;
using TextUtils;

namespace TestLibrary
{
    public class TextUtils_GetWordCountShould
    {
        [Fact]
        public void IgnoredCasing()
        {
            var wordCount = WordCount.GetWordCount("Jack", "Jack Jack");
            Assert.Equal(2, wordCount);
        }

        [Theory]
        [InlineData(0, "Ting", "Does not appear in the string.")]
        [InlineData(1, "Ting", "Ting appears one.")]
        [InlineData(2, "Ting", "Ting appears twice with Ting.")]
        public void CountInstanceCorrectly (int count, string searchWord, string inputString)
        {
            Assert.Equal(count, WordCount.GetWordCount(searchWord, inputString));
        }
    }
}
