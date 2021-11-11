using System;
namespace MyC_App
{
    class C_3
    {
        public void AgeCalculator() 
        { 
            Console.WriteLine("Enter your date of birth in format YYYY/MM/DD : ");
            string dateOfBirth = Console.ReadLine();
            DateTime dob = Convert.ToDateTime(dateOfBirth);
            int age = 0;
            age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear) 
                age--;
            Console.Write("Your age is : " + age);
            return;
        }
    }
}
