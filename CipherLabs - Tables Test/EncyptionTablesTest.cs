using CipherLabs.Core;
using CipherLabs.Core.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CipherLabs___Tables_Test
{
    [TestClass]
    public class EncyptionTablesTest
    {
        [TestMethod]
        [TestCategory("EncyptionTable - Exceptions")]
        [ExpectedException(typeof(CipherException), "Keyword is empty or null")]
        public void EmptyKeywordTest()
        {
            new EncryptionTable().Encode("", "", 2);
        }

        [TestMethod]
        [TestCategory("EncyptionTable - Exceptions")]
        [ExpectedException(typeof(CipherException), "Keyword has duplicate characters")]
        public void DuplicateCharactersTest()
        {
            new EncryptionTable().Encode("", "kaka", 2);
        }

        [TestMethod]
        [TestCategory("EncyptionTable - Exceptions")]
        [ExpectedException(typeof(CipherException), "Rows count must be greater than 2")]
        public void RowsCountTest()
        {
            new EncryptionTable().Encode("", "ka", 1);
        }

        [TestMethod]
        [TestCategory("EncyptionTable - Exceptions")]
        [ExpectedException(typeof(CipherException), "Rows count is short, may be a data loss")]
        public void DataLossTest()
        {
            new EncryptionTable().Encode("tomuchtext", "ka", 2);
        }

        [TestMethod]
        [TestCategory("EncyptionTable - Encode")]
        [DataRow("ИСХОДНИЙ ТЕКСТ", "КЛЮЧ", 4, "ИДС_СНТТХИ_ЕОЙ_К")]
        [DataRow("СИРНИЙ соус", "СИР", 4, "ИоСЙуИ_сРс_Н")]
        [DataRow("hello world", "dumbface", 2, "dw_h_rol_o_e_l_l")]
        public void EncodeTest(string phrase, string keyword, int rows, string expected)
        {
            Assert.AreEqual(new EncryptionTable().Encode(phrase, keyword, rows), expected);
        }

        [TestMethod]
        [TestCategory("EncyptionTable - Decode")]
        [DataRow("ИДС_СНТТХИ_ЕОЙ_К", "КЛЮЧ", 4, "ИСХОДНИЙ ТЕКСТ")]
        [DataRow("ИоСЙуИ_сРс_Н", "СИР", 4, "СИРНИЙ соус")]
        [DataRow("dw_h_rol_o_e_l_l", "dumbface", 2, "hello world")]
        public void DecodeTest(string phrase, string keyword, int rows, string expected)
        {
            Assert.AreEqual(new EncryptionTable().Decode(phrase, keyword, rows), expected);
        }
    }
}