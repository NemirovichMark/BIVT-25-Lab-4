public double[] Task11(double a, double b, int n)
{
    double[] array = null;

    // code here
    if (n <= 0)
        return null;
    
    if (n == 1 && a == b)
    {
        array = new double[] { a };
        return array;
    }
    
    if (a == b || n <= 1)
        return null;
    
    array = new double[n];
    
    if (a < b)
    {
        double step = (b - a) / (n - 1);
        for (int i = 0; i < n; i++)
        {
            array[i] = a + i * step;
        }
    }
    else // a > b
    {
        double step = (a - b) / (n - 1);
        for (int i = 0; i < n; i++)
        {
            array[i] = a - i * step;
        }
    }
    // end

    return array;
}
