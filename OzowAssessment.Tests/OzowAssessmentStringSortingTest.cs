using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;

namespace OzowAssessment.Tests
{
    public class OzowAssessmentStringSortingTest
    {
        private readonly StringProcessor _processor;
        private readonly string _input;
        public OzowAssessmentStringSortingTest()
        {
            _processor = new StringProcessor();
            _input = "Contrary to popular belief, the pink unicorn flies east";
        }
        [Fact]
        public void ShouldRemovePunctuationsTest()
        {
            var expectedResult = "Contrarytopopularbeliefthepinkunicornflieseast";
            var output = _processor.StringExcludePunctuation(_input);

            Assert.NotEmpty(output);
            Assert.Equal(expectedResult, output);
        }
        [Fact]
        public void ShouldThrowExceptionForNullInput()
        {
            var expectedResult = "input";
            var actual = Assert.Throws<ArgumentNullException>(() => _processor.StringExcludePunctuation(null));
            
            Assert.Equal(expectedResult, actual.ParamName);
        }

        [Fact]
        public void ShouldSortStringInAlphabeticOrder()
        {
            var expectedResult = "aaabcceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy";
           var strippedPunctuation= _processor.StringExcludePunctuation(_input);
            var actual = _processor.StringSorting(strippedPunctuation);

            Assert.Equal(expectedResult, actual);
            
        }
    }
}
