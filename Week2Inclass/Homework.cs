namespace Week2
{
    // antwoord is ez, in elke stad kan het worden gegeven. Er staat namelijk geen limiet bij!  

    internal static class Homework
    {
        const int MATRIXSIZE = 6;
        internal static void opgave1()
        {
            int[,] Matrix = new int[MATRIXSIZE, MATRIXSIZE]
            {
                { 0, 50, 135, 120, 65, 65},
                { 50, 0, 140, 75, 20, 70 },
                { 135, 140, 0, 220, 170, 75},
                { 120, 75, 220, 0, 55, 145},
                { 65, 20, 170, 55, 0, 90},
                { 65, 70, 75, 145, 90, 0}
            };
            string[] CityNames = { "Arnhem", "Amersfoort", "Assen", "Rotterdam", "Utrecht", "Zwolle" };

            int WhichCity = 0;
            int[] TotalCityDistances = new int[MATRIXSIZE];

            for (int x = 0; x < MATRIXSIZE; x++)
            {
                for (int y = 0; y < MATRIXSIZE; y++)
                {
                    TotalCityDistances[x] += Matrix[x, y];
                }
            }
            int ShortestDistance = TotalCityDistances[0];
            for (int i = 0; i < MATRIXSIZE; i++)
            {
                if (TotalCityDistances[i] < ShortestDistance)
                {
                    ShortestDistance = TotalCityDistances[i];
                    WhichCity = i;
                }
            }
            Console.WriteLine($"de plek waar bijles moet worden gegeven is in: {CityNames[WhichCity]} ");
        }
    }
}
