namespace ProblemSolving
{
    public static class StairCase
    {
        /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int hash = i + 1;
                string staircase = "";

                while (hash >= 1)
                {
                    staircase += "#";
                    hash--;
                }

                Console.WriteLine(staircase.PadLeft(n - hash));
            }
        }
    }
}
