using CipherLabs.Core;
using CipherLabs.Core.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CipherLabs___Playfair_Cipher_Test
{
    [TestClass]
    public class PlayFairCipherTest
    {
        [TestMethod]
        [TestCategory("PlayfairCipher - Exceptions")]
        [ExpectedException(typeof(CipherException), "Keyword is empty")]
        public void EmptyKeywordTest()
        {
            new PlayfairCipher().Encode("test", "");
        }

        [TestMethod]
        [TestCategory("PlayfairCipher - Exceptions")]
        [ExpectedException(typeof(CipherException), "Keyword has duplicate characters")]
        public void DuplicateCharactersTest()
        {
            new PlayfairCipher().Encode("test", "ttset");
        }

        [TestMethod]
        [TestCategory("PlayfairCipher - Exceptions")]
        [ExpectedException(typeof(CipherException), "Keyword contains not allowed characters")]
        public void NotAllowedCharactersTest()
        {
            var cipher = new PlayfairCipher();
            cipher.Alphabet = Alphabets.UkrainianSpecial;
            cipher.Encode("тест", "not");
        }

        [TestMethod]
        [TestCategory("PlayfairCipher - Encode")]
        [DataRow("abcdefghijklmnopqrstuvwxyz #$%&()*,./:;?@[\\]^`{}~", "Test", "Test", "Dted")]
        [DataRow("abcdefghijklmnopqrstuvwxyz #$%&()*,./:;?@[\\]^`{}~", "umpalumpa", "pie", "mddemtfdcy")]
        [DataRow("абвгґдеєжзиіїйклмнопрстуфхцчшщьюя #$%&()*,./:;?@[\\]^`{}~", "Сирний соус", "Сир", "Ґсамґеяинтия")]
        public void Encode(string alphabet, string input, string keyword, string output)
        {
            var cipher = new PlayfairCipher();
            cipher.Alphabet = alphabet;
            Assert.AreEqual(cipher.Encode(input, keyword), output);
        }

        [TestMethod]
        [TestCategory("PlayfairCipher - Encode")]
        [DataRow("abcdefghijklmnopqrstuvwxyz #$%&()*,./:;?@[\\]^`{}~", "Dted", "Test", "Test")]
        [DataRow("abcdefghijklmnopqrstuvwxyz #$%&()*,./:;?@[\\]^`{}~", "mddemtfdcy", "pie", "umpalumpa ")]
        [DataRow("абвгґдеєжзиіїйклмнопрстуфхцчшщьюя #$%&()*,./:;?@[\\]^`{}~", "Ґсамґеяинтия", "Сир", "Сирний соус ")]
        public void Decode(string alphabet, string input, string keyword, string output)
        {
            var cipher = new PlayfairCipher();
            cipher.Alphabet = alphabet;
            Assert.AreEqual(cipher.Decode(input, keyword), output);
        }
    }
}