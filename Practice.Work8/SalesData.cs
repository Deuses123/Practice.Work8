namespace Practice.Work8;

public class SalesData
{
    private double[] sales;

    public SalesData(int months)
    {
        sales = new double[months];
    }

    public double this[int month]
    {
        get
        {
            if (IsValidMonth(month))
            {
                return sales[month - 1];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Недопустимый месяц.");
            }
        }
        set
        {
            if (IsValidMonth(month))
            {
                sales[month - 1] = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Недопустимый месяц.");
            }
        }
    }

    public int MonthCount
    {
        get { return sales.Length; }
    }

    private bool IsValidMonth(int month)
    {
        return month >= 1 && month <= sales.Length;
    }
    
    public void CalculateRegressionCoefficients(SalesData salesData, out double a, out double b)
    {
        int n = salesData.MonthCount;
        double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;

        for (int month = 1; month <= n; month++)
        {
            double x = month;
            double y = salesData[month];

            sumX += x;
            sumY += y;
            sumXY += x * y;
            sumX2 += x * x;
        }

        a = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
        b = (sumY - a * sumX) / n;
    }
}