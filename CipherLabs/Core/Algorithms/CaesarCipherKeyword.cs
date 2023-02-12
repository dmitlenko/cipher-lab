using System.Text;

namespace CipherLabs.Core.Algorithms
{
    public class CaesarCipherKeyword
    {
        private string alphabet = null;

        public CaesarCipherKeyword(string alphabet)
        {
            this.alphabet = alphabet.ToUpper();
        }

        public string Alphabet { get => alphabet; set => alphabet = value.ToUpper(); }

        public string Decode(string phrase, int key, string keyword)
        {
            StringBuilder p = new StringBuilder(phrase);
            string a = prepareAlphabet(this.alphabet, keyword, key);

            for (int i = 0; i < p.Length; i++)
                if (a.Contains(p[i].ToString().ToUpper()))
                {
                    p[i] = alphabet[Tools.Number.Mod(a.IndexOf(char.ToUpper(p[i])), a.Length)];

                    if (char.IsLower(phrase[i])) p[i] = char.ToLower(p[i]);
                }
                else p[i] = phrase[i];

            return p.ToString();
        }

        public string Encode(string phrase, int key, string keyword)
        {
            StringBuilder p = new StringBuilder(phrase);
            string a = prepareAlphabet(this.alphabet, keyword, key);

            for (int i = 0; i < p.Length; i++)
                if (a.Contains(p[i].ToString().ToUpper()))
                {
                    p[i] = a[Tools.Number.Mod(alphabet.IndexOf(char.ToUpper(p[i])), a.Length)];

                    if (char.IsLower(phrase[i])) p[i] = char.ToLower(p[i]);
                }
                else p[i] = phrase[i];

            return p.ToString();
        }

        private string prepareAlphabet(string alphabet, string keyPhrase, int key)
        {
            foreach (char c in keyPhrase.ToUpper())
                alphabet = alphabet.Remove(alphabet.IndexOf(c), 1);

            return Tools.String.ShiftString(keyPhrase.ToUpper() + alphabet, Tools.Number.Mod(key, alphabet.Length));
        }
    }
}