using System;
using Strategy_oodp_3.Interfaces;

namespace Strategy_oodp_3.AreaСalculation
{
    public class CircleCalculator :ISquarable
    {
        const double pi = 3.14;
        public int GetValue(int size)
        {
            if (size == 0)
                return 0;
            return Convert.ToInt16(size * pi);
        }
    }
}
