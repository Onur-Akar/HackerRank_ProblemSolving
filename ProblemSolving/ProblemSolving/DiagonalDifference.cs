using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public static class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftDiag = 0;
            int rightDiag = 0;


            for (int i = 0, j = (arr.Count - 1); i < arr.Count; i++, j--)
            {
                leftDiag += arr[i][i];
                rightDiag += arr[i][j];
            }

            if (leftDiag > rightDiag)
            {
                return (leftDiag - rightDiag);
            }
            else
            {
                return (rightDiag - leftDiag);
            }
        }
    }
}
