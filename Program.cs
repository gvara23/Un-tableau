namespace Un_tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creation of the arrays with the same size
            int[] firstArray = new int[3];
            int[] secondArray = new int[3];

            // Assigning values to the indices of the first two tables

            for (int i = 0; i < 3; i++)
            {
                firstArray[i] = i + 1; 
                secondArray[i] = i + 4;
            }

            // Creation of the Third array like this (firstarray + secondarray = the size of the thirdArray)
            int[] thirdArray = new int[firstArray.Length + secondArray.Length];

            //use values of the first and second array to put in the third array using Array.Copy()
            Array.Copy(firstArray, 0, thirdArray, 0, firstArray.Length);

            Array.Copy(secondArray, 0, thirdArray, firstArray.Length, secondArray.Length);

            // Put the thrid array to verify if i didnt mess up like usual :)
            Console.WriteLine("Third Array : ");
            foreach (int num in thirdArray)
            {
                Console.WriteLine(num);
            }
        }
    }
}
