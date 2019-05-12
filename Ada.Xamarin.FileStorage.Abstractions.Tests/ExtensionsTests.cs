using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace Ada.Xamarin.FileStorage.Abstractions.Tests
{
    [ExcludeFromCodeCoverage]
    public class ExtensionsTests
    {
        [Fact]
        public void CleanByeOrderMarkNotNeeded()
        {
            byte[] original = new byte[] { 0xEB, 0xFB, 0xBF };

            byte[] expected = new byte[] { 0xEB, 0xFB, 0xBF };

            byte[] actual = original.CleanByteOrderMark();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CleanByeOrderMarkNeeded()
        {
            byte[] original = new byte[] { 0xEF, 0xBB, 0xBF, 0xEB, 0xFB, 0xBF };

            byte[] expected = new byte[] { 0xEB, 0xFB, 0xBF };

            byte[] actual = original.CleanByteOrderMark();

            Assert.Equal(expected, actual);
        }
    }
}
