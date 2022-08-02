using System;

namespace No4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int[] sequenceArray = new int[]{1, 1, 1,2, 3, 2, 2, 2, 1, 1, 1, 1};
            
             int count = 1;
             int finalCount = 1;
             int finalIndex = 0;

			


			for (int i = 0; i < sequenceArray.Length - 1; i++) 
			{
                if (sequenceArray[i] == sequenceArray[i + 1]) finalCount++;
                else finalCount = 1;

				if (finalCount > count) 
				{
					count = finalCount;
					finalIndex = sequenceArray [i];
				}
			}

			for (int i = 0; i < count; i++) 
            {
                Console.Write (finalIndex + " ");
            }
        }
    }
}
