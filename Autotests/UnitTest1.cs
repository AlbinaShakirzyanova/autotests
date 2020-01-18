using System;
using Xunit;

namespace Autotests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void Test2()
        {

        }

        [Fact]
        public void Test3()
        {
            throw new Exception("It is OK");
        }
    }
}
