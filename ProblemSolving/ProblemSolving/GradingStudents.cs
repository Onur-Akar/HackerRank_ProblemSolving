namespace ProblemSolving
{
    public static class GradingStudents
    {
        /*
         * Complete the 'gradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         */

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> roundedGrades = grades.Select(g => g < 38 ? g : (5 - g % 5) < 3 ? (g + (5 - g % 5)) : g).ToList();

            return roundedGrades;
        }
    }
}
