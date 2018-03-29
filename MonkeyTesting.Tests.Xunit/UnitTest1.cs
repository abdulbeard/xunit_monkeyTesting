using System;
using CuriousGeorge.xunit;
using Xunit;

namespace CuriousGeorge.Tests.Xunit
{
    public class UnitTest1
    {
        [Theory]
        [MonkeyTest(typeof(UnitTest1), nameof(Test1))]
        public void Test1(int a, int b, int c)
        {
            //var pertumationResult = Permutations.HeapsAlgorithm(4, new int[] { 0, 1, 2, 3 });
        }

        [Theory]
        [MonkeyTest(typeof(UnitTest1), nameof(Test2))]
        public void Test2(int a, float b, decimal c)
        {

        }

        [Theory]
        [MonkeyTest(typeof(UnitTest1), nameof(Test3))]
        public void Test3(Guid a, float b, decimal c)
        {

        }

        [Theory]
        [MonkeyTest(typeof(UnitTest1), nameof(Test4))]
        public void Test4(Guid a, float b, Yolo c)
        {

        }

        [Theory]
        [MonkeyTest(typeof(UnitTest1), nameof(Test5), true)]
        public void Test5(Yolo c)
        {

        }
    }

    public enum Yolo
    {
        Really,
        NoSeriously,
        AreYoForReal
    }
}