﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysOfTDD.UnitTests
{
    [TestFixture]
    public class StringUtilsTest
    {
        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            var sentenceToScan = "TDD is awesome!";
            var characterToScanFor = "e";
            var expectedResult = 2;

            var stringUtils = new StringUtils();
            int result = stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInAComplexSentence()
        {
            var sentenceToScan = "Once is unique, twice is a coincidence, three times is a pattern.";
            var characterToScanFor = "n";
            var expectedResult = 5;

            var stringUtils = new StringUtils();
            int result = stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldGetAnArgumentExceptionWhenCharacterToScanForIsLargerThanOneCharacter()
        {
            var sentenceToScan = "This test should throw an exception";
            var characterToScanFor = "xx";
            var stringUtils = new StringUtils();

            Assert.Throws<ArgumentException>(() =>
                stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor)
            );

        }

        [Test]
        public void Add()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
