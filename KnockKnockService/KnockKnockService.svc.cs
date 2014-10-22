using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KnockKnockService
{
    public class RedPillService : KnockKnockService.IRedPill
    {
        #region What Is Your Token

        public Guid WhatIsYourToken()
        {
            return new Guid("ef6cbf99-bc7b-4356-9a9b-2c6fa1066033");
        }

        #endregion

        #region Reverse Words

        public string ReverseWords(string value)
        {
            if (value == null)
            {
                throw new FaultException<ArgumentNullException>(new System.ArgumentNullException("Value cannot be null. Parameter name: s"), "Value cannot be null. Parameter name: s");
            }

            StringBuilder stringBuild = new StringBuilder(string.Empty);
            var arrayOfWords = value.Split(' ');

            if (arrayOfWords.Count() == 1)
            {
                char[] charArray = value.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }

            for (var x = 0; x <= arrayOfWords.Length - 1; x++)
            {
                char[] charArray = arrayOfWords[x].ToCharArray();
                Array.Reverse(charArray);
                if (x != arrayOfWords.Length - 1)
                    stringBuild.AppendFormat("{0} ", new string(charArray));
                else
                    stringBuild.AppendFormat("{0}", new string(charArray));
            }
            return stringBuild.ToString();
        }

        #endregion

        #region Fibonacci Number

        public long FibonacciNumber(long number)
        {

            const int MAX = 92;
            const int MIN = -93;
            if (number > MAX || number < MIN)
            {
                throw new FaultException<System.ArgumentOutOfRangeException>(new System.ArgumentOutOfRangeException("Fib(>92) will cause a 64-bit integer overflow.Parameter name: n"), "Fib(>92) will cause a 64-bit integer overflow.Parameter name: n");
            }

            var myfibNumbers = new Dictionary<long, long>();
            myfibNumbers.Add(0, 0);
            myfibNumbers.Add(1, 1);
            myfibNumbers.Add(-1, 1);

            if (number == 0 || number == -1 || number == 1)
                return myfibNumbers[number];

            if (number > -2)
            {
                for (int i = 2; i <= number; i++)
                {
                    myfibNumbers.Add(i, myfibNumbers[i - 2] + myfibNumbers[i - 1]);
                }
            }
            else
            {
                for (int i = -2; i >= number; i--)
                {
                    myfibNumbers.Add(i, (myfibNumbers[i + 2] - myfibNumbers[i + 1]));
                }
            }

            return myfibNumbers[number];

        }

        #endregion

        #region What Shape Is This

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {

            if (a <= 0 || b <= 0 || c <= 0)
            {
                return TriangleType.Error;
            }

            int[] values = new int[3] { a, b, c };

            if (AllThreeSidesAreEqual(values))
            {
                return TriangleType.Equilateral;
            }

            if (a + b == c || a + c == b || b + c == a)
                return TriangleType.Error;

            if ((a + b) < c || (a + c) < b || (b + c) < a)
                return TriangleType.Error;

            if (NoSidesAreEqual(values))
            {
                return TriangleType.Scalene;
            }

            if (TwoSidesAreEqual(values))
            {
                return TriangleType.Isosceles;
            }

            return TriangleType.Error;
        }

        private static bool AllThreeSidesAreEqual(int[] values)
        {
            return values.Distinct().Count() == 1;
        }
        private static bool TwoSidesAreEqual(int[] values)
        {
            return values.Distinct().Count() == 2;
        }
        private static bool NoSidesAreEqual(int[] values)
        {
            return values.Distinct().Count() == 3;
        }

        #endregion

    }
}
