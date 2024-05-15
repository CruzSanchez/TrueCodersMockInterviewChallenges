namespace TrueCodersMockInterviewChallenges.Library
{
    public class Challenge
    {
        //Challenge 1
        //Write a method called GenerateSequence that takes an int named n as parameters and returns an int array containing the numbers from 1 to n.
        //Example - int n = 5 your return value would be an array that looks like this [1, 2, 3, 4, 5]
        //Always assume n >= 0 if the input is 0, return an empty array

        public int[] GenerateSequence(int n)
        {
            if (n == 0)
            {
                return Array.Empty<int>();
            }

            int[] sequence = new int[n];

            for (int i = 0; i < n; i++)
            {
                sequence[i] = i + 1;
            }

            return sequence;
        }


        //Challenge 2
        //Write a method named CountVowels that takes a string as a parameter and returns an int representing the number of vowels found within the string.
        //Vowels are considered to be (aeiou) NOT 'y', ignore case - 'A' and 'a' are both valid inputs
        //If there are not any vowels in the input string return 0

        public int CountVowels(string data)
        {
            int vowelCount = 0;
            char[] vowels = new[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

            foreach (char character in data)
            {
                if (vowels.Contains(character))
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }


        //Challenge 3
        //Create a method named FindLargest that accepts an int array as parameters and returns an int representing the largest number.
        //Example - [3, 1, 10, 7, 6] you would return 10 since it is the largest number in the array
        //If the input array is empty return 0

        public int FindLargest(int[] data)
        {
            if (data.Length <= 0)
            {
                return 0;
            }

            int largest = data[0];

            foreach (var item in data)
            {
                if (item > largest)
                {
                    largest = item;
                }
            }

            return largest;
        }


        //Challenge 4
        //Write a method named FindOnesAndZeros that accepts an int array as a parameter and returns an int representing the count of the number of 1s AND 0s present in the array.
        //Any other value can be ignored.
        //Example - input [1, 1, 0, 3, 0, 0, 2, 1, 2, 3, 5] you would return 6 since there are 3 ones and 3 zeros
        //If the input array is empty return 0

        public int FindZerosAndOnes(int[] data)
        {
            int count = 0;

            foreach (var item in data)
            {
                if (item == 0 || item == 1)
                {
                    count++;
                }
            }

            return count;
        }


        //Challenge 5        
        //Write a method named CountFalse that takes a bool array as parameters and returns an int that represents the number of times false appears
        //Example - [true, false, false] would return 2 since there are 2 false elements in the array
        //If the input array is empty return 0

        public int CountFalse(bool[] data)
        {
            if (data.Length <= 0)
            {
                return 0;
            }

            int count = 0;

            foreach (var item in data)
            {
                if (item == false)
                {
                    count++;
                }

                //or
                //if (!item)
                //{
                //    count++;
                //}
            }

            return count;
        }


        //Challenge 6
        //Write a method named BetweenTwoInts that takes two integers (a, b) as parameters and return an array of all integers between the input parameters, including them.
        //Always assume a < b
        //Example a = -1, b = 3 you would return [-1, 0, 1, 2, 3]

        public int[] BetweenTwoInts(int a, int b)
        {
            var numbers = new List<int>();

            for (int i = a; i <= b; i++)
            {
                numbers.Add(i);
            }

            return numbers.ToArray();
        }
    }
}
