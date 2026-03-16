using System.Linq;

namespace APBD_01
{
    public class StatisticsHelper
    {
        public double CalculateAverage(int[] values)
        {
            if (values == null || values.Length == 0) return 0;
            return values.Average();
            double sum = 0;
            foreach (int i in values) sum += i;
            return sum / values.Length;
        }

        public int CalculateMin(int[] values)
        {
            return 0;
        }
    }
}