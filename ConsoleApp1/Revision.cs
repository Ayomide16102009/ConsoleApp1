namespace ConsoleApp1
{
    public class Revision
    {
        public void EvenOrOdd()
        {
            Console.WriteLine("enter any number");
            int anyNumber = Convert.ToInt32(Console.ReadLine());

            if (anyNumber % 2 == 0)
            {
                Console.WriteLine("This number is an even number");
            }
            else
            {
                Console.WriteLine("This number is an odd number");
            }
        }

        public void Loop()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

        }

        public void MultipliationInLoop()
        {


            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }

        }

        public void LeapYear()
        {
            Console.WriteLine("enter year");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0 || year % 100 == 0 && year % 4 == 0)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }

        public void ReverseOrder()
        {
            string names = "Ayomide";
            int length = names.Length;

            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write(names[i]);
            }
        }

        public void SumOfArrayElement()
        {
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;
            int length = numbers.Length;

            for (int i = 0; i <= length - 1; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }

        public void MultiplicationOfArrayElement()
        {
            int[] numbers = { 2 * 10 };
            int multiplication = 0;
            int length = numbers.Length;

            for (int i = 0; i <= length - 1; i++)
            {
                multiplication += numbers[i];
            }
            Console.WriteLine(multiplication);
        }

        public void REverseOrder()
        {
            string names = "Ayomide";
            int length = names.Length;

            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write(names[i]);
            }
        }

        public void Largest()
        {
            int[] numbers = { 1, 3, 5, 7, 5, 10 };
            Console.Write(numbers[5]);
        }

        public void AscendingOrder()
        {
            int[] numbers = { 2, 1, 6, 4, 7, 9, 8 };
            Array.Sort(numbers);
            {
                Console.WriteLine("Ascending order:");
                foreach (int num in numbers)
                {
                    Console.Write(num + " ");
                }

            }
        }

        public void DescendingOrder()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.Reverse(numbers);
            {
                Console.WriteLine("Descending order:");
                foreach (int num in numbers)
                {
                    Console.Write(num + " ");
                }
            }
        }

        public void REVerseOrder()
        {
            string[] names = { "Ayomide" };
            Array.Reverse(names);
            {
                Console.WriteLine("Descending order:");
                foreach (string nam in names)
                {
                    Console.Write(nam + " ");
                }
            }
        }

        public void CountEvenAndOdd()
        {
            int Even = 0;
            int Odd = 0;
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Even++;
                }
                else
                {
                    Odd++;
                }
            }
            Console.WriteLine($"Even: {Even} and Odd: {Odd}");
        }

        public void DuplicateElement()
        {
            int[] numbers = { 1, 2, 3, 2, 4, 5, 1 };
            int sum = 0;
            int length = numbers.Length;

            for (int i = 0; i <= length - 1; i++)
            {
                sum += numbers[i];
            }
            Console.Write(sum);
        }

        public void Main()
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string? input = Console.ReadLine();

            string[] inputArray = input.Split(' ');

            int[] numbers = Array.ConvertAll(inputArray, int.Parse);

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine("The sum of the array is: " + sum);
        }
    }
}
