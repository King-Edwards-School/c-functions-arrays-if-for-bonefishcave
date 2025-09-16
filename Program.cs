namespace Console_Blank_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "diddy", "chiddy", "fiddy" };
            PrintElements(names);
            int[] integers = { 546, 9578, 413, 544 };
            printSumIntegers(integers);
            for (int repeatTimes = 2; repeatTimes < 100; repeatTimes++)
            {
                bool isPrime = checkPrime(repeatTimes);
                Console.WriteLine(Convert.ToString(repeatTimes)+ "is a prime: " + Convert.ToString(isPrime));

             
            }
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
            for (int i =0; i < data.Length; i++) // sets i as temporary variable and uses it to cycle through all elements in the array.
            {
                int sum = 0;
                sum += data[i];
                Console.WriteLine(sum); 
            }
        }
    
        static bool checkPrime(int number)
        {
            bool isPrime = true;
            for (int i = 2; i< number; i++) // sets i as temporary variable which can be used to cycle through all numbers less than the input number
            {
                if (number % i == 0) // if the input number is divisible by any number other than 1 and itself, it is not prime
                {
                    isPrime = false;
                   
                }
            }
            return isPrime; // will return the unchanged isPrime = true if no divisors found 
        }
        
    
    
    }   
}