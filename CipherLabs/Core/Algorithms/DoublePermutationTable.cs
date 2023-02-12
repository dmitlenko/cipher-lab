using System.Text;

namespace CipherLabs.Core.Algorithms
{
    public class DoublePermutationTable
    {
        public char EmptyCharacter { get; set; } = ' ';

        public string Decode(string phrase, string vKeyword, string hKeyword)
        {
            CheckArguments(phrase, vKeyword, hKeyword);

            var matrix = GenerateMatrix(phrase, hKeyword.Length, vKeyword.Length, true);

            return Tools.Matrix.ReadCharMatrix(matrix, false);
        }

        public string Encode(string phrase, string vKeyword, string hKeyword)
        {
            CheckArguments(phrase, vKeyword, hKeyword);

            var matrix = GenerateMatrix(phrase, hKeyword.Length, vKeyword.Length, false);

            return Tools.Matrix.ReadCharMatrix(matrix, true);
        }

        private void CheckArguments(string phrase, string vKeyword, string hKeyword)
        {
            if (Tools.String.IsFullyEmpty(vKeyword) || Tools.String.IsFullyEmpty(hKeyword))
                throw new CipherException("One of the keywords is empty");
            if (!Tools.String.IsDigitsOnly(vKeyword) || !Tools.String.IsDigitsOnly(hKeyword))
                throw new CipherException("One of the keywords contain not allowed symbols");
            if (!Tools.String.IsCountinous(vKeyword) ||
                !(Tools.String.MinimumDigit(vKeyword) == 1 && Tools.String.MaximumDigit(vKeyword) == vKeyword.Length))
                throw new CipherException("Vertical keyword contains non-continous order");
            if (!Tools.String.IsCountinous(hKeyword) ||
                !(Tools.String.MinimumDigit(hKeyword) == 1 && Tools.String.MaximumDigit(hKeyword) == hKeyword.Length))
                throw new CipherException("Horizontal keyword contains non-continous order");
            if (hKeyword.Length * vKeyword.Length < phrase.Length)
                throw new CipherException("Keywords is too short, may be a data loss");
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

        private char[,] MakeColumnSwaps(char[,] matrix, string from, string to)
        {
            StringBuilder fromSB = new StringBuilder(from);
            int current = 0, matrix_rows = matrix.GetLength(0);

            while (fromSB.ToString() != to)
            {
                if (current >= from.Length) current = Tools.Number.Mod(current, from.Length);

                if (fromSB[current] == to[current])
                {
                    current++;
                    continue;
                }

                for (int i = 0; i < matrix_rows; i++)
                    Tools.Matrix.SwapRowItems(matrix, i, current, to.IndexOf(fromSB[current]));

                (fromSB[current], fromSB[to.IndexOf(fromSB[current])]) = (fromSB[to.IndexOf(fromSB[current])], fromSB[current]);

                current++;
            }

            return matrix;
        }
    }
}