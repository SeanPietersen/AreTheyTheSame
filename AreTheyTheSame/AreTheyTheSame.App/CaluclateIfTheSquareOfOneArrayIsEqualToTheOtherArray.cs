using System;
using System.Linq;

namespace AreTheyTheSame.App
{
    public class CaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray : ICaluclateIfTheSquareOfOneArrayIsEqualToTheOtherArray
    {
        public bool comp(int[] a, int[] b)
        {
            var listA = a.ToList();
            if(a == null || b == null)
            {
                return false;
            }
            else
            {
                if (a.Length == b.Length)
                {
                    foreach (var numberB in b)
                    {

                        double squareRoot = Math.Sqrt(numberB);

                        if(squareRoot%1 != 0)
                        {
                            return false;
                        }
                        if (listA.Contains((int)squareRoot))
                        {
                            var indexOfNumber = listA.IndexOf((int)squareRoot);
                            listA.RemoveAt(indexOfNumber);
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return true;

                }
                return false;
            }                       
        }
    }
}
