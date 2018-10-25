using System;
using Xunit;
using library;

namespace test_library
{
    public class LibraryTest
    {
        [Fact]
        public void TestThing()
        {
            Assert.Equal (42, new Thing().Get(19, 23));
        }
    }
}
