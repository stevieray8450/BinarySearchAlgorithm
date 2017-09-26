using System;
namespace BinarySearch
{
    public static class BinarySearchClass
    {
        public static int[] MyArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public static int Search(int[] array) 
        {
            int start, mid, end = 0;
            int arrLength = MyArray.Length;
			end = arrLength - 1;
			mid = end / 2;
            bool valueFound = false;

            while (!valueFound)
            {
                if (array[mid] == 1)
                {
                    valueFound = true;
                    return mid;
                }
                else if (array[mid] > 1)
                {
                    end = mid;
                    mid = end / 2;
                }
                else if (array[mid] < 1)
                {
                    start = mid;
                    mid = (start + end) / 2;
                }
            }
            return -1;
        }
    }
}
