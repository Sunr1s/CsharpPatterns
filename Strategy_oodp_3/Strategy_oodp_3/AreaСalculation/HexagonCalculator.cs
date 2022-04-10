using Strategy_oodp_3.Interfaces;

namespace Strategy_oodp_3.AreaСalculation
{
    public class HexagonCalculator : ISquarable
    {
        public int GetValue(int size)
        {
            if (size == 0)
                return 0;
            return size * 6;
        }
    }
}
