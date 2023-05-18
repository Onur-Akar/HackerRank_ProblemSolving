namespace ProblemSolving
{
    public static class MinMaxSum
    {
        /*
         * Complete the 'miniMaxSum' function below.
         * 
         * The function accepts INTEGER_ARRAY arr as parameter.
        */

        public static void miniMaxSum(List<int> arr)
        {
            List<long> calcs = new List<long>();
            for (int i = 0; i < arr.Count; i++)
            {
                List<int> nArr = new List<int>();
                nArr.AddRange(arr);
                nArr.RemoveAt(i);

                long calc = 0;

                for (int j = 0; j < nArr.Count; j++)
                {
                    calc += nArr[j];
                }

                calcs.Add(calc);
            }

            Console.WriteLine($"{calcs.Min()} {calcs.Max()}");
        }

    }
}
