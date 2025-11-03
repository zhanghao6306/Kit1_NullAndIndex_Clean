using System;
using Kit1_NullAndIndexLib;
using Xunit;

namespace Kit1_NullAndIndex.Tests
{
    public class NullAndIndexTests
    {
        [Trait("TestCategory", "Nulls")]
        [Fact(DisplayName = "ArgumentNullException when name is null")]
        public void ArgumentNull_on_Null_String()
        {
            string? name = null;
            Assert.Throws<ArgumentNullException>(() => DangerousOps.LengthOfName(name));
        }

        [Trait("TestCategory", "Index")]
        [Fact(DisplayName = "ArgumentOutOfRangeException on invalid index")]
        public void ArgumentOutOfRange_on_Invalid_Index()
        {
            var data = DangerousOps.MakeArray(3);
            Assert.Throws<ArgumentOutOfRangeException>(() => DangerousOps.GetAt(data, 10));
        }

        [Trait("TestCategory", "Index")]
        [Fact(DisplayName = "ArgumentNullException on null array")]
        public void ArgumentNull_on_Null_Array()
        {
            int[]? data = null;
            Assert.Throws<ArgumentNullException>(() => DangerousOps.GetAt(data, 0));
        }

        [Trait("TestCategory", "HappyPath")]
        [Fact(DisplayName = "No exception on valid input")]
        public void No_Exception_On_Valid()
        {
            var data = DangerousOps.MakeArray(3);
            var len = DangerousOps.LengthOfName("abc");
            Assert.Equal(3, len);
            Assert.Equal(2, DangerousOps.GetAt(data, 1));
        }
    }
}
