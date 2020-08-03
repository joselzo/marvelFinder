using marvelFinder.Controllers;
using marvelFinder.Helper;
using Microsoft.Extensions.Caching.Memory;
using System;
using Xunit;

namespace marvelFinderTest
{
    public class UnitTest1
    {
        private IMemoryCache _cache;
        SuperHeroesAPI APIHELPER = new SuperHeroesAPI();
        //CharacterController charac = new CharacterController();
        string numericT = "1";
        string notNumericT = "Super";
        string busquedainCorrecta = "";

        [Fact]
        public void TestApiHelperNumeric()
        {
            var response = APIHELPER.Finder(numericT);
           Assert.NotNull(response);
           Assert.True(true);
        }
        [Fact]
        public void TestApiHelperNotNumeric()
        {
            var response = APIHELPER.Finder(notNumericT);
            Assert.NotNull(response);
            Assert.True(true);
        }
    }
}
