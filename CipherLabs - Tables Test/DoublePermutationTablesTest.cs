using CipherLabs.Core;
using CipherLabs.Core.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CipherLabs___Tables_Test
{
    [TestClass]
    public class DoublePermutationTablesTest
    {

        [TestMethod]
        [TestCategory("DoublePermutationTable - Exceptions")]
        [ExpectedException(typeof(CipherException), "One of the keywords is empty")]
        public void EmptyKeywordTest1()
        {
            new DoublePermutationTable().Encode("Test", "12", "");
        }

        [TestMethod]
        [TestCategory("DoublePermutationTable - Exceptions")]
        [ExpectedException(typeof(CipherException), "One of the keywords is empty")]
        public void EmptyKeywordTest2()
        {
            new DoublePermutationTable().Encode("Test", "", "12");
        }

        [TestMethod]
        [TestCategory("DoublePermutationTable - Exceptions")]
        [ExpectedException(typeof(CipherException), "One of the keywords contain not allowed symbols")]
        public void UnallowedCharactersTest1()
        {
            new DoublePermutationTable().Encode("Test", "12q", "12");
        }

        [TestMethod]
        [TestCategory("DoublePermutationTable - Exceptions")]
        [ExpectedException(typeof(CipherException), "One of the keywords contain not allowed symbols")]
        public void UnallowedCharactersTest2()
        {
            new DoublePermutationTable().Encode("Test", "12", "12q");
        }

        [TestMethod]
        [TestCategory("DoublePermutationTable - Exceptions")]
        [ExpectedException(typeof(CipherException), "Vertical keyword contains non-continous order")]
        public void NonContinousVerticalTest1()
        {
            new DoublePermutationTable().Encode("Test", "124", "12");
        }

        [TestMethod]
        [TestCategory("DoublePermutationTable - Exceptions")]
        [ExpectedException(typeof(CipherException), "Vertical keyword contains non-continous order")]
        public void NonContinousVerticalTest2()
        {
            new DoublePermutationTable().Encode("Test", "23", "12");
        }

        [TestMethod]
        [TestCategory("DoublePermutationTable - Exceptions")]
        [ExpectedException(typeof(CipherException), "Vertical keyword contains non-continous order")]
        public void NonContinousVerticalTest3()
        {
            new DoublePermutationTable().Encode("Test", "122", "12");
        }

        [TestMethod]
        [TestCategory("DoublePermutationTable - Exceptions")]
        [ExpectedException(typeof(CipherException), "Horizontal keyword contains non-continous order")]
        public void NonContinousHorizontalTest1()
        {
            new DoublePermutationTable().Encode("Test", "12", "124");
        }

        [TestMethod]
        [TestCategory("DoublePermutationTable - Exceptions")]
        [ExpectedException(typeof(CipherException), "Horizontal keyword contains non-continous order")]
        public void NonContinousHorizontalTest2()
        {
            new DoublePermutationTable().Encode("Test", "12", "23");
        }

        [TestMethod]
        [TestCategory("DoublePermutationTable - Exceptions")]
        [ExpectedException(typeof(CipherException), "Horizontal keyword contains non-continous order")]
        public void NonContinousHorizontalTest3()
        {
            new DoublePermutationTable().Encode("Test", "12", "122");
        }

        [TestMethod]
        [TestCategory("DoublePermutationTable - Exceptions")]
        [ExpectedException(typeof(CipherException), "Keywords is too short, may be a data loss")]
        public void ShortKeywordsTest()
        {
            new DoublePermutationTable().Encode("This is to much text for you :)", "12", "12");
        }

        [TestMethod]
        [TestCategory("DoublePermutationTable - Encode")]
        [DataRow("i want some cheese", "4132", "23415", "o_hateei_s__secwm_en")]
        [DataRow("i'd like to drink some sweet cola drink", "1437256", "415236", "'erelno_tnt__el_kod__iwdkoisdei_akmic__r_s")]
        [DataRow("КОЛА МОЛА ЛА-ЛА-ЛА", "54321", "12345", "_-ЛМК_ЛАОО_А-ЛЛ__ЛАА__А__")]
        public void EncodeTest(string phrase, string key1, string key2, string expected)
        {
            Assert.AreEqual(new DoublePermutationTable().Encode(phrase, key1, key2), expected);
        }

        [TestMethod]
        [TestCategory("DoublePermutationTable - Decode")]
        [DataRow("o_hateei_s__secwm_en", "4132", "23415", "i want some cheese")]
        [DataRow("'erelno_tnt__el_kod__iwdkoisdei_akmic__r_s", "1437256", "415236", "i'd like to drink some sweet cola drink")]
        [DataRow("_-ЛМК_ЛАОО_А-ЛЛ__ЛАА__А__", "54321", "12345", "КОЛА МОЛА ЛА-ЛА-ЛА")]
        public void DecodeTest(string phrase, string key1, string key2, string expected)
        {
            Assert.AreEqual(new DoublePermutationTable().Decode(phrase, key1, key2), expected);
        }
    }
}
