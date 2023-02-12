namespace CipherLabs.Core
{
    public class Tools
    {
        public static int Mod(int a, int n) => (a % n) < 0 ? (a % n) + n : (a % n);

        public static string ShiftString(string s, int count) => (s + s).Substring(s.Length - count, s.Length);

        public static void SwapRowItems<T>(T[,] matrix, int row, int from, int to) => (matrix[row, from], matrix[row, to]) = (matrix[row, to], matrix[row, from]);

        //public static void SwapRows<T>(T[,] matrix, int from, int to) => (matrix[from], matrix[to]) = (matrix[to], matrix[from]);
    }
}