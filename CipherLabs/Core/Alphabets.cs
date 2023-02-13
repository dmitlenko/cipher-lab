namespace CipherLabs.Core
{
    public class Alphabets
    {
        public static string English { get => "abcdefghijklmnopqrstuvwxyz"; }
        public static string Ukrainian { get => "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя"; }
        public static string Special { get => "#$%&()*,./:;?@[\\]^`{}~"; }
        public static string EnglishSpecial { get => English + ' ' + Special; }
        public static string UkrainianSpecial { get => Ukrainian + ' ' + Special; }
    }
}