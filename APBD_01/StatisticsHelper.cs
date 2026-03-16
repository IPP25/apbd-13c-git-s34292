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
        public int CalculateMax(int[] values)
        {
            if (values == null || values.Length == 0) return int.MinValue; 
            int max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max) max = values[i];
            }
            return max;
            
        }
        
    }
}