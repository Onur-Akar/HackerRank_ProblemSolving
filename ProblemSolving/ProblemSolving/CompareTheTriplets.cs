namespace ProblemSolving
{
    public static class CompareTheTriplets
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> award = new List<int>();
            award.Add(0);
            award.Add(0);

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    award[0] += 1;
                }
                else if (b[i] > a[i])
                {
                    award[1] += 1;
                }
            }

            return award;
        }
    }
}
