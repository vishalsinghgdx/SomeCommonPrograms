namespace CommonProgram
{
    /// <summary>
    /// Find peak element
    /// </summary>
    public class FindPeakElement
    {
        int[] numbers = { 1, 4, 5, 6, 7, 8 };
        int peak = 0;
        
        public int PeakElement()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(peak <= numbers[i])
                {
                    peak = numbers[i];
                }
            }
            return peak;
        }

    }
}
