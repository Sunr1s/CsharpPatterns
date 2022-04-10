using Strategy_oodp_3.Interfaces;

namespace Strategy_oodp_3.AreaСalculation
{
    class Сalculation
    {
        public int GetValue(ISquarable calculator, int size) 
        { 
            return calculator.GetValue(size);
        }
    }
}
