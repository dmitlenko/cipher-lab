using System;
using System.Linq;
using System.Text;

namespace CipherLabs.Core.Algorithms
{
    public class AffineCipher
    {
        private string alphabet = null;

        public AffineCipher(string alphabet)
        {
            Alphabet = alphabet;
        }

        public string Alphabet { get => alphabet; set => alphabet = value.ToUpper(); }

        public bool IsCoprime(int a, int b)
        {
            int ld, ldRem;

            while (b > 0)
            {
                ld = a / b;
                ldRem = a % b;
                a = b;
                b = ldRem;
            }
            if (a == 1) return true;
            return false;
        }

        public string Encode(string phrase, int a, int b)
        {
            StringBuilder result = new StringBuilder(phrase);

            if (a < 0 || a > alphabet.Length) throw new CipherException("a > m or a < 0");
            if (b < 0 || b > alphabet.Length) throw new CipherException("b > m or b < 0");
            if (!IsCoprime(a, alphabet.Length)) throw new CipherException("НОД(a,m) != 1");

            for (int i = 0; i < result.Length; i++)
                if (alphabet.Contains(char.ToUpper(result[i])))
                {
                    result[i] = alphabet[Tools.Number.Mod(a * alphabet.IndexOf(char.ToUpper(result[i])) + b, alphabet.Length)]; 

                    if (char.IsLower(phrase[i])) result[i] = char.ToLower(result[i]);
                }
                else continue;

            return result.ToString();
        }

        public string Decode(string phrase, int a, int b)
        {
            StringBuilder result = new StringBuilder(phrase);
            int invA = 0, flag;

            if (a < 0 || a > alphabet.Length) throw new CipherException("a > m or a < 0");
            if (b < 0 || b > alphabet.Length) throw new CipherException("b > m or b < 0");
            if (!IsCoprime(a, alphabet.Length)) throw new CipherException("НОД(a,m) != 1");

            for (int i = 0; i < alphabet.Length; i++)
            {
                flag = (a * i) % alphabet.Length;
                if (flag == 1) invA = i;
            }

            for (int i = 0; i < result.Length; i++)
                if (alphabet.Contains(char.ToUpper(result[i])))
                {
                    result[i] = alphabet[Tools.Number.Mod(invA * (alphabet.IndexOf(char.ToUpper(result[i])) + alphabet.Length - b), alphabet.Length)];

                    if (char.IsLower(phrase[i])) result[i] = char.ToLower(result[i]);
                }
                else continue;

            return result.ToString();
        }
    }
}