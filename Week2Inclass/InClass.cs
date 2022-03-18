namespace Week2
{
    internal static class InClass
    {
        public static void oefening2()
        {
            int[] randomNums = new int[60];
            Random r = new Random();

            int greatestNum = 0;

            for (int i = 0; i < 60; i++)
            {
                randomNums[i] = r.Next(100);
                Console.WriteLine(randomNums[i]);
                if (randomNums[i] > greatestNum)
                {
                    greatestNum = randomNums[i];
                }


            }

            Console.WriteLine($"the biggest number in the array is: {greatestNum}");
        }

        const int ArraySize = 30;
        const int maxNumber = 30;

        public static void oefening3()
        {
            int[] randomNums = generateRandomArray(ArraySize, maxNumber);
            Random r = new Random();
            int smallestNum = maxNumber;
            int timesSmallestNum = 0;
            int SecondSmallestNum = maxNumber;
            int timesSecondSmallestNum = 0;

            for (int i = 0; i < ArraySize; i++)
            {
                if (randomNums[i] < smallestNum)
                {
                    smallestNum = randomNums[i];
                    timesSmallestNum = 0;
                }
                if (randomNums[i] == smallestNum)
                {
                    timesSmallestNum++;
                }
                if (randomNums[i] < SecondSmallestNum && randomNums[i] > smallestNum)
                {
                    SecondSmallestNum = randomNums[i];
                    timesSecondSmallestNum = 0;
                }
                if (randomNums[i] == SecondSmallestNum)
                {
                    timesSecondSmallestNum++;
                }
            }

            Console.WriteLine($"the smallest number was: {smallestNum} and it appeared {timesSmallestNum} time(s) in the random array");
            Console.WriteLine($"the second smallest number was: {SecondSmallestNum} and it appeared {timesSecondSmallestNum} time(s) in the random array");
        }

        public static int[] generateRandomArray(int size, int maxNum)
        {
            Random r = new Random();
            int[] genArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                genArray[i] = r.Next(maxNum);
                Console.WriteLine($"{i}: {genArray[i]}");
            }
            return genArray;
        }

        public static void oefening4()
        {
            List<int> lijst = new List<int>();

            for (int i = 10000; i < 1000000; i++)
            {
                lijst.Add(i);
            }

            long som = 0;
            foreach (int i in lijst)
            {
                som += i;
            }
            Console.WriteLine(som);
        }
    }
}
