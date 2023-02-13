using System;
using System.Linq;
using System.Text;

namespace CipherLabs.Core.Algorithms
{
    public class PlayfairCipher
    {
        public string Alphabet { get; set; }

        public char EmptyCharacter { get => ' '; }

        public string Encode(string phrase, string keyword)
        {
            CheckArguments(phrase, keyword);

            return PrepareOutput(phrase, Cipher(GenerateMatrix(Alphabet, keyword.ToLower()), PreparePhrase(phrase), false));
        }

        public string Decode(string phrase, string keyword)
        {
            CheckArguments(phrase, keyword);

            return PrepareOutput(phrase, Cipher(GenerateMatrix(Alphabet, keyword.ToLower()), PreparePhrase(phrase), true));
        }

        private void CheckArguments(string phrase, string keyword)
        {
            if (Tools.String.IsFullyEmpty(keyword))
                throw new CipherException("Keyword is empty");
            if (Tools.String.RemoveDuplicates(keyword).Length != keyword.Length)
                throw new CipherException("Keyword has duplicate characters");
            if (!Tools.String.BelongsTo(keyword.ToLower(), Alphabet))
                throw new CipherException("Keyword contains not allowed characters");
        }

        private string PreparePhrase(string phrase, bool lower = true)
        {
            if (phrase.Length % 2 != 0)
                phrase += " ";
            return lower ? phrase.ToLower() : phrase;
        }

        private char[,] GenerateMatrix(string alphabet, string keyword)
        {
            alphabet = Tools.String.RemoveDuplicates(keyword + alphabet + EmptyCharacter + Alphabets.Special);

            int size = (int)Math.Ceiling(Math.Sqrt(alphabet.Length));

            char[,] matrix = new char[size, size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if (alphabet.Length > (i * size + j)) matrix[i, j] = alphabet[i * size + j];
                    else matrix[i, j] = EmptyCharacter;

            return matrix;
        }

        private string Cipher(char[,] matrix, string keyword, bool invert)
        {
            string result = string.Empty;
            int inc = invert ? 1 : -1;
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);

            for (int i = 0; i < keyword.Length; i += 2)
            {
                (int row1, int col1) = Tools.Matrix.GetValueCoords(matrix, keyword[i]);
                (int row2, int col2) = Tools.Matrix.GetValueCoords(matrix, keyword[i + 1]);

                if (row1 == row2 && col1 == col2)
                    result += new string(new char[] { 
                        matrix[Tools.Number.Mod((row1 + inc), rows), Tools.Number.Mod((col1 + inc), cols)],
                        matrix[Tools.Number.Mod((row1 + inc), rows), Tools.Number.Mod((col1 + inc), cols)] 
                    });
                else if (row1 == row2)
                    result += new string(new char[] { 
                        matrix[row1, Tools.Number.Mod((col1 + inc), cols)], 
                        matrix[row1, Tools.Number.Mod((col2 + inc), cols)] 
                    });
                else if (col1 == col2)
                    result += new string(new char[] { 
                        matrix[Tools.Number.Mod((row1 + inc), rows), col1], 
                        matrix[Tools.Number.Mod((row2 + inc), rows), col1] 
                    });
                else
                    result += new string(new char[] { 
                        matrix[row1, col2], 
                        matrix[row2, col1] 
                    });
            }

            return result;
        }

        private string PrepareOutput(string original, string phrase)
        {
            original = PreparePhrase(original, false);
            StringBuilder output = new StringBuilder(phrase);

            for(int i = 0; i < original.Length; i++)
                if (char.IsUpper(original[i]))
                    output[i] = char.ToUpper(output[i]);

            return output.ToString();
        }
    }
}