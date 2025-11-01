namespace ConsoleApp1
{
    public class Addition1
    {
        public int Addition()
        {
            Console.WriteLine("enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int total = firstNumber + secondNumber;
            Console.WriteLine($"The addition of {firstNumber} + {secondNumber} = {total}");

            return total;
        }

        public int Multiplication()
        {
            Console.WriteLine("enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int total = firstNumber * secondNumber;
            Console.WriteLine($"The multiplication of {firstNumber} * {secondNumber} = {total} ");

            return total;
        }

        public int Division()
        {
            Console.WriteLine("enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int total = firstNumber / secondNumber;
            Console.WriteLine($"The division of {firstNumber} / {secondNumber} = {total}");

            return total;
        }

        public int Subtraction()
        {
            Console.WriteLine("enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int total = firstNumber - secondNumber;
            Console.WriteLine($"The subtraction of {firstNumber} - {secondNumber} = {total} ");

            return total;
        }

        public bool GreaterThan()
        {
            Console.WriteLine("enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(true);
                return true;
            }
            else
            {
                Console.WriteLine(false);
                return false;
            }

        }

        public void Vote()
        {
            Console.WriteLine("enter the number");
            int theNumber = Convert.ToInt32(Console.ReadLine());

            if (theNumber >= 18)
            {
                Console.WriteLine("vote");
            }
            else
            {
                Console.WriteLine("don't vote");
            }
        }

        public void Week()
        {
            int days = 5;
            switch (days)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }




        }

        public void NYSC()
        {
            Console.WriteLine("enter required age");
            int requiredAge = Convert.ToInt32(Console.ReadLine());

            if (requiredAge >= 20 && requiredAge <= 30)
            {
                Console.WriteLine("You are eligible for NYSC");
            }
            else
            {
                Console.WriteLine("You are not eligible for NYSC");
            }
        }

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
    }
}
