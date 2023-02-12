using System.Text;

namespace CipherLabs.Core.Algorithms
{
    /// <summary>
    /// Class to encode and decode string using Caesar Cipher
    /// </summary>
    public class CaesarCipher
    {
        /// <summary>
        /// String that stores alphabet
        /// </summary>
        private string alphabet = null;

        /// <summary>
        /// Constructor for the Ceaser Cipher class
        /// </summary>
        /// <param name="alpabet">Alphabet for the encoder and decoder</param>
        public CaesarCipher(string alphabet)
        {
            Alphabet = alphabet;
        }

        /// <summary>
        /// Alphabet
        /// </summary>
        public string Alphabet { get => alphabet; set => alphabet = value.ToUpper(); }

        /// <summary>
        /// Decode given phrase with Caesar Cipher
        /// </summary>
        /// <param name="phrase">Phrase to decode</param>
        /// <param name="key">Encoding key</param>
        /// <returns>Decoded string</returns>
        public string Decode(string phrase, int key)
        {
            return Encode(phrase, -key);
        }

        /// <summary>
        /// Encode given phrase with Caesar Cipher
        /// </summary>
        /// <param name="key">Encoding key</param>
        /// <param name="phrase">Phrase to encode</param>
        /// <returns></returns>
        public string Encode(string phrase, int key)
        {
            StringBuilder stringBuilder = new StringBuilder(phrase);
            for (int i = 0; i < stringBuilder.Length; i++)
                if (alphabet.Contains(stringBuilder[i].ToString().ToUpper()))
                {
                    stringBuilder[i] = alphabet[index: Tools.Mod(alphabet.IndexOf(char.ToUpper(stringBuilder[i])) + key, alphabet.Length)];

                    if (char.IsLower(phrase[i])) stringBuilder[i] = char.ToLower(stringBuilder[i]);
                }
                else
                    stringBuilder[i] = phrase[i];
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Modulus operator that behaves the same way as the Python % operator
        /// </summary>
        /// <param name="a">Left operand</param>
        /// <param name="n">Right operand</param>
        /// <returns>Modulus</returns>
    }
}