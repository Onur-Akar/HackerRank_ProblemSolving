namespace ProblemSolving
{
    public static class BirthDayCakeCandles
    {
        /*
         * Complete the 'birthdayCakeCandles' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY candles as parameter.
         */

        public static int birthdayCakeCandles(List<int> candles)
        {
            List<int> counts = new List<int>();
            counts.Add(candles[0]);

            for (int i = 1; i < candles.Count; i++)
            {
                if (candles[i] > counts[0])
                {
                    counts = new List<int>();
                    counts.Add(candles[i]);
                }
                else if (candles[i] == counts[0])
                {
                    counts.Add(candles[i]);
                }
            }
            return counts.Count;
        }
    }
}
