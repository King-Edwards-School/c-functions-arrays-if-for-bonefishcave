namespace Console_Blank_6
{
    internal class Program
    {
        static void Main(string[] args) // place to call functions and give them parameters
        {
            string[] names = { "diddy", "chiddy", "fiddy" }; //1
            PrintElements(names);

            int[] integers = { 546, 9578, 413, 544 }; //2
            printSumIntegers(integers);

            for (int repeatTimes = 2; repeatTimes < 100; repeatTimes++) //3
            {
                bool isPrime = checkPrime(repeatTimes);
                Console.WriteLine(Convert.ToString(repeatTimes) + "is a prime: " + Convert.ToString(isPrime));
            }

            int[] unsorted = { 5, 3, 56, 3, 78, 12, 324, 5, 23, 4 }; //4 
            bubbleSort(unsorted);

            int[] integersForSearch = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,16,200 }; //5 
            binarySearch(integersForSearch);

        }
        static void PrintElements(string[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }

        }

        static void printSumIntegers(int[] data) // void means it doesn't return anything
        {
            for (int i = 0; i < data.Length; i++) // sets i as temporary variable and uses it to cycle through all elements in the array.
            {
                int sum = 0;
                sum += data[i];
                Console.WriteLine(sum);
            }
        }

        static bool checkPrime(int number)
        {
            bool isPrime = true;
            for (int i = 2; i < number; i++) // sets i as temporary variable which can be used to cycle through all numbers less than the input number
            {
                if (number % i == 0) // if the input number is divisible by any number other than 1 and itself, it is not prime
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime; // will return the unchanged isPrime = true if no divisors found 
        }

        static void bubbleSort(int[] data)
        {
            int length = data.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
                Console.WriteLine("Sorted array: ");
                for (int i = 0; i < length; i++)
                {
                    Console.Write(data[i] + " ");
                }
                Console.WriteLine();
            }
        }

        static void binarySearch(int[] data)
        {
            int length = data.Length;
            int target = 12;
            int leftEnd = 0;
            int rightEnd = length - 1;
            while (leftEnd <= rightEnd) // Continue searching while there is a range to search
            {
                int mid = leftEnd + (rightEnd - leftEnd) / 2; // Find the middle index of the current search range
                if (data[mid] == target)
                //mid is the position of the target
                {
                    Console.WriteLine("Found target at index: " + mid);
                    return;
                }
                if (data[mid] < target)
                {
                    leftEnd = mid + 1; // Search in the right half
                }
                else
                {
                    rightEnd = mid - 1; // Search in the left half
                }
            }
            Console.WriteLine(-1); //target not found
            
            // This is not working in the terminal because i dont know how to change .net version on VScode (apple) although copilot says there's no syntax errors
        }
    }
}