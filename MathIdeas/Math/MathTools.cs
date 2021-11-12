using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathIdeas.Services;

namespace MathIdeas
{
    public static class MathTools
    {
        public static void CollatzProblemSolver(int number)
        {
            bool limiter = true;

            for(int num = number;  limiter; num++)
            {
                CollatzProblemNumbersFinder(num);
            }
        }
        private static void CollatzProblemNumbersFinder(int number)
        {
            List<int> logNumbers = new List<int>() {number};
            int workNumber = number;

            while(workNumber != 1 || logNumbers.Count() == 1)
            {
                if(IsEven(workNumber))
                {
                    workNumber = workNumber / 2;

                }else if(IsOddAndNotZero(workNumber))
                {
                    workNumber = workNumber * 3 + 1;
                }

                if(workNumber == 1)
                {
                    logNumbers.Add(workNumber);

                    LoggingService.Log(logNumbers);

                    break;
                }

                logNumbers.Add(workNumber);
            }
        }
        private static bool IsEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }
        private static bool IsOddAndNotZero(int number)
        {
            if(number != 0)
            {
                return !IsEven(number);
            }

            return false;
        }
    }
}
