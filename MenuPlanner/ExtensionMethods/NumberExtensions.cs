using System.Runtime.CompilerServices;

namespace MenuPlanner.ExtensionMethods
{
    public static class NumberExtensions
    {
        public static int Sum<T>(this T tuple) where T : ITuple
        {
            int sum = 0;
            for (int i = 0; i < tuple.Length; i++)
            {
                if (tuple[i] is int intValue)
                {
                    sum += intValue;
                }
            }
            return sum;
        }
    }
}
