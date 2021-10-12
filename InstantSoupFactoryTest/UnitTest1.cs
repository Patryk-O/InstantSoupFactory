using InstantSoupFactory;
using System;
using Xunit;

namespace InstantSoupFactoryTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestChickenSoup()
        {
            var factory = new SoupWithChickenFactory();
            var soupA = factory.createSoup();

            Assert.Equal("hmm pasta with chicken soup", soupA.Pasta());
        }
        [Fact]
        public void TestChickenHotSoup()
        {
            var factory = new SoupWithChickenFactory();
            var soupA = factory.createHotSoup();

            Assert.Equal("hmm hot pasta with chicken soup", soupA.Pasta());
            Assert.Equal("Hot sauce to chicken", soupA.HotSauce());
        }
        [Fact]
        public void TestBeefHotSoup()
        {
            var factory = new SoupWithBeefFactory();
            var soupA = factory.createHotSoup();

            Assert.Equal("hmm hot pasta with beef soup", soupA.Pasta());
            Assert.Equal("Hot sauce to beef", soupA.HotSauce());
        }
        [Fact]
        public void TestBeefSoup()
        {
            var factory = new SoupWithBeefFactory();
            var soupA = factory.createHotSoup();

            Assert.Equal("hmm hot pasta with beef soup", soupA.Pasta());
            Assert.Equal("Hot sauce to beef", soupA.HotSauce());
        }
    }
}
