using System.Linq;

namespace APBD_01
{
    public class StatisticsHelper
    {
        public double CalculateAverage(int[] values)
        {
            if (values == null || values.Length == 0) return 0;
            return values.Average();
        }
    }
}