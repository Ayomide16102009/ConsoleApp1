namespace ConsoleApp1
{
    public class Addition2
    {
        public void School()
        {
            Console.WriteLine("enter eligible age");
            int eligibleAge = Convert.ToInt32(Console.ReadLine());

            if (eligibleAge >= 3 && eligibleAge <= 20)
            {
                Console.WriteLine("You are admitted to our school");
            }
            else
            {
                Console.WriteLine("You are not admitted to our school");
            }
        }

        public void Calculation()
        {
            Console.WriteLine("enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter third number");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            int total = firstNumber * secondNumber + thirdNumber;
            Console.WriteLine($"The calculation of {firstNumber} * {secondNumber} + {thirdNumber} = {total}");


        }

        public void SimpleInterest()
        {
            Console.WriteLine("enter  principal");
            int principal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the rate");
            int rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the time");
            int time = Convert.ToInt32(Console.ReadLine());

            int SimpleInterest = principal * rate * time;
            Console.WriteLine($"The multiplication of {principal} * {rate} * {time} = {SimpleInterest}");
        }
    }
}
