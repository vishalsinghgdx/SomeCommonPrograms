namespace CommonProgram
{
    public class MergeAlternateArray
    {
        public static string MergeAlternately(string word1, string word2)
        {
            char[] c1 = word1.ToCharArray();
            char[] c2 = word2.ToCharArray();

            string merged = "";
            int counter = 0;
            for (int i = 0; i < c1.Length; i++)
            {
                if (counter < c1.Length) merged += c1[i];
                if (counter < c2.Length) merged += c2[i];
                counter++;
            }

            for (int i = counter; i < c2.Length; i++)
            {
                merged += c2[i];
            }

            return merged;
        }
    }

}
