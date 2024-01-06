namespace JaggedArrays;
class Program
{
    private static void Main(string[] args)
    {
        int[] jan = new int[31]; // int array
        int[] feb = new int[29]; // int array

        int[][] sales = new int[][] { jan, feb }; // Jagged Array

        int month, day, total;
        double ave;

        sales[0][0] = 41;
        sales[0][1] = 42;
        sales[0][2] = 43;
        sales[0][3] = 44;
        sales[0][4] = 48;
        sales[0][5] = 45;
        sales[0][6] = 45;

        sales[1][0] = 45;
        sales[1][1] = 47;
        sales[1][2] = 42;
        sales[1][3] = 78;
        sales[1][4] = 29;
        sales[1][5] = 48;
        sales[1][6] = 36;

        for (month = 0; month <= 1; month++)
        {
            total = 0;
            for (day = 0; day <= 6; day++)
            {
                total += sales[month][day];
            }
            ave = total / 7f;

            Console.WriteLine($"Average sales for month: {month}: {ave:F2}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
