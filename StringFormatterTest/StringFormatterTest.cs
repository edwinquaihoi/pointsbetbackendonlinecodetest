using Xunit;

namespace PointsBet_Backend_Online_Code_Test 
{

    public class StringFormatterTest 
    {
        [Fact]
        public void TestToCommaSeparatedList()
        {
            string result1 = StringFormatter.ToCommaSeparatedList(["A", "B", "C"], ",");
            Assert.Equal("A,B,C", result1);
        }

        [Fact]
        public void TestToCommaSeparatedListWithEmptySpace()
        {
            string result2 = StringFormatter.ToCommaSeparatedList(["A", "B", "C"], "");
            Assert.Equal("ABC", result2);
        }

        [Fact]
        public void TestToCommaSeparatedListWithEmptyList()
        {
            string result3 = StringFormatter.ToCommaSeparatedList([], "");
            Assert.Equal("", result3);
        }

        [Fact]
        public void TestToCommaSeparatedListWithMultiCharDelimiter()
        {
            string result4 = StringFormatter.ToCommaSeparatedList(["A", "B"], "!@#$");
            Assert.Equal("A!@#$B", result4);
        }

        [Fact]
        public void TestToCommaSeparatedListWithOneItem()
        {
            string result5 = StringFormatter.ToCommaSeparatedList(["A"], ",");
            Assert.Equal("A", result5);
        }

        [Fact]
        public void TestToCommaSeparatedListWithNullList()
        {
            string result5 = StringFormatter.ToCommaSeparatedList(null, ",");
            Assert.Equal("", result5);
        }
    }
}
