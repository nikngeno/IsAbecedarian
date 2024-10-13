namespace IsAbecedarian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAbecedarian("bandeer"));
            Console.WriteLine(IsAbecedarian("dehort"));
        }
        public static bool IsAbecedarian(string word)
        {
            char[] letters = word.ToCharArray();
            for (int i = 0; i < letters.Length - 1; i++)
            {
                if (letters[i] > letters[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
