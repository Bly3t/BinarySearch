using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        private static int _position;
        private static int Search(int[] array, int target, out int _position)
        {
            int left = 0;
            int right = array.Length;
            int mid = left + (right - left) / 2;

            if(array.Any() == false)
            {
                return _position = -1;
            }

            while(array[mid] != target)
            {
                if(mid == target)
                {
                    return _position = mid;
                }
                if(array[mid] < target)
                {
                    left = mid + 1;
                }
                if(array[mid] > target)
                {
                    right = mid - 1;
                }
                if(left >= right) // No target in array
                {
                    return _position = -1;
                }
                mid = left + (right - left) / 2;
            }
            return _position = mid;
        }
        private static int[] SortArray(int[] array)
        {
            var sortedArray = Enumerable.Range(0, array.Length).Select(x => array[x]).OrderBy(x => x).ToArray();
            return sortedArray;
        }
        static void Main(string[] args)
        {
            int[] array = { 100, 200, 3, 7, 2, 21, 41, 34 }; //2,3,7,21,34,41,100,200
            int[] sortedArray = SortArray(array);
            int target = 34;
            Console.WriteLine($"Target {target} is on position: {Search(sortedArray, target, out _position)}");
        }
    }
}
