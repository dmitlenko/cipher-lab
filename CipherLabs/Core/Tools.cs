using System;
using System.Linq;

namespace CipherLabs.Core
{
    public class Tools
    {
        public static class Matrix
        {
            public static string ReadCharMatrix(char[,] matrix, bool vertical, string ret = "")
            {
                if (vertical)
                    for (int i = 0; i < matrix.GetLength(1); i++)
                        for (int j = 0; j < matrix.GetLength(0); j++)
                            ret += matrix[j, i];
                else
                    for (int i = 0; i < matrix.GetLength(0); i++)
                        for (int j = 0; j < matrix.GetLength(1); j++)
                            ret += matrix[i, j];

                return ret;
            }

            public static void SwapRowItem<T>(T[,] matrix, int row, int from, int to) => (matrix[row, from], matrix[row, to]) = (matrix[row, to], matrix[row, from]);

            public static void SwapColumnItem<T>(T[,] matrix, int col, int from, int to) => (matrix[from, col], matrix[to, col]) = (matrix[to, col], matrix[from, col]);

            public static Tuple<int,int> GetValueCoords<T>(T[,] matrix, T value)
            {
                for(int i = 0; i < matrix.GetLength(0); i++)
                    for(int j = 0; j < matrix.GetLength(1); j++)
                        if (matrix[i,j].Equals(value))
                            return Tuple.Create(i, j);

                return Tuple.Create(-1, -1);
            }
        }

        public static class Number
        {
            public static int Mod(int a, int n) => (a % n) < 0 ? (a % n) + n : (a % n);
        }

        public static class String
        {
            public static bool IsCountinous(string str)
            {
                var arr = str.Select(ch => ch - '0').ToArray();
                Array.Sort(arr);

                for (int i = 1; i < arr.Length; i++)
                    if (arr[i] - arr[i - 1] > 1)
                        return false;

                return true;
            }

            public static bool IsDigitsOnly(string str)
            {
                foreach (char c in str)
                    if (c < '0' || c > '9')
                        return false;

                return true;
            }

            public static bool IsFullyEmpty(string str) => string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
            public static int MaximumDigit(string str)
            {
                var arr = Sort(str).Select(ch => ch - '0').ToArray();

                return arr[arr.Length - 1];
            }

            public static int MinimumDigit(string str)
            {
                var arr = Sort(str).Select(ch => ch - '0').ToArray();

                return arr[0];
            }

            public static string ShiftString(string s, int count) => (s + s).Substring(s.Length - count, s.Length);

            public static string Sort(string keyword) => string.Concat(keyword.OrderBy(c => c));
        }

        //public static void SwapRows<T>(T[,] matrix, int from, int to) => (matrix[from], matrix[to]) = (matrix[to], matrix[from]);
    }
}