using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CipherLabs.Core.Algorithms
{
    public class EncryptionTable
    {
        public EncryptionTable()
        { }

        public char EmptyCharacter { get; set; } = ' ';

        public string Decode(string phrase, string keyword, int rows)
        {
            CheckArguments(phrase, keyword, rows);

            var matrix = MakeSwaps(GenerateMatrix(phrase, rows, keyword.Length, false), SortKeyword(keyword), keyword.ToUpper());
            string ret = string.Empty;

            for (int i = 0; i < keyword.Length; i++)
                for (int j = 0; j < rows; j++)
                    ret += matrix[j, i];

            return ret.Replace('_', ' ').TrimEnd();
        }

        public string Encode(string phrase, string keyword, int rows)
        {
            CheckArguments(phrase, keyword, rows);

            var matrix = MakeSwaps(GenerateMatrix(phrase, rows, keyword.Length, true), keyword.ToUpper(), SortKeyword(keyword));
            string ret = string.Empty;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < keyword.Length; j++)
                    ret += matrix[i, j];

            return ret.Replace(' ', '_');
        }

        private void CheckArguments(string phrase, string keyword, int rows)
        {
            if (string.IsNullOrEmpty(keyword) || string.IsNullOrWhiteSpace(keyword))
                throw new CipherException("Keyword is empty or null");
            if (string.Join("", new HashSet<char>(keyword.ToUpper())) != keyword.ToUpper())
                throw new CipherException("Keyword has duplicate characters");
            if (rows < 2)
                throw new CipherException("Rows count must be greater than 2");
            if (rows * keyword.Length < phrase.Length)
                throw new CipherException("Rows count is short, may be a data loss");
        }

        private char[,] GenerateMatrix(string phrase, int rows, int cols, bool vertical)
        {
            char[,] matrix = new char[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if (phrase.Length - 1 >= (j * rows + i) && vertical) matrix[i, j] = phrase[j * rows + i];
                    else if (phrase.Length - 1 >= (i * cols + j) && !vertical) matrix[i, j] = phrase[i * cols + j];
                    else matrix[i, j] = EmptyCharacter;

            return matrix;
        }

        private char[,] MakeSwaps(char[,] matrix, string from, string to)
        {
            StringBuilder fromSB = new StringBuilder(from);
            int current = 0, matrix_rows = matrix.GetLength(0);

            while (fromSB.ToString() != to)
            {
                if (current >= from.Length) current = Tools.Mod(current, from.Length);

                if (fromSB[current] == to[current])
                {
                    current++;
                    continue;
                }

                for (int i = 0; i < matrix_rows; i++)
                    Tools.SwapRowItems(matrix, i, current, to.IndexOf(fromSB[current]));

                (fromSB[current], fromSB[to.IndexOf(fromSB[current])]) = (fromSB[to.IndexOf(fromSB[current])], fromSB[current]);

                current++;
            }

            return matrix;
        }

        private string SortKeyword(string keyword)
        {
            return string.Concat(keyword.ToUpper().OrderBy(c => c));
        }
    }
}