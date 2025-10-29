using System.Linq;

namespace Lab4
{
    public class Program
    {
        public static void Main()
        {
            int[] mas = { -2, -1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, -7, 8, 8, -1, 0, 0, 5, -5, -8, 2, 3 };
            int[] mas1 = { 2, 1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 0, 0, 5, 5, 8, 2, 3, -9999 };
            Purple purp = new Purple();
            purp.Task8(mas, mas1);
        }
    }
}
