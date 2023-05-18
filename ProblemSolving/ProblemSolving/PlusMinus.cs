namespace ProblemSolving
{
    public static class PlusMinus
    {
        /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

        public static void plusMinus(List<int> arr)
        {
            decimal zeros = 0.000000m;
            decimal positives = 0.000000m;
            decimal negatives = 0.000000m;

            decimal divider = Convert.ToDecimal(arr.Count);

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == 0)
                {
                    zeros++;
                }
                else if (arr[i] > 0)
                {
                    positives++;
                }
                else
                {
                    negatives++;
                }
            }

            Console.WriteLine((positives / divider).ToString("N6"));
            Console.WriteLine((negatives / divider).ToString("N6"));
            Console.WriteLine((zeros / divider).ToString("N6"));
        }
    }
}
