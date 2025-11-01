namespace ConsoleApp1
{
    public class MySelf
    {
        public void MyDetails()
        {
            Console.WriteLine("welcome to the class of Happiness");

            Console.WriteLine("enter your surname");
            string? yourSurname = (Console.ReadLine());

            Console.WriteLine("enter your first name");
            string? yourFirstName = (Console.ReadLine());

            Console.WriteLine("enter your second name");
            string? yourSecondName = (Console.ReadLine());

            Console.WriteLine("enter your third name");
            string? yourThirdName = (Console.ReadLine());

            Console.WriteLine("enter your age");
            int yourAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your date of birth");
            int yourDateOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your month of birth");
            string? yourMonthOfBirth = (Console.ReadLine());

            Console.WriteLine("enter your year of birth");
            int yourYearOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your school name");
            string? yourSchoolName = (Console.ReadLine());

            Console.WriteLine("enter your class");
            string? yourClass = (Console.ReadLine());

            Console.WriteLine("enter your gender");
            string? yourGender = (Console.ReadLine());

            Console.WriteLine("enter your NIN");
            int yourNIN = Convert.ToInt32(Console.ReadLine());
        }
    }
}
