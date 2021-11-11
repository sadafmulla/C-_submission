using System;

namespace MyC_App
{
    class MainClass
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\nChoose the question no from 1 to 5 : \n (Enter 6 for exit)");
                string opt = Console.ReadLine();
                int ch = Convert.ToInt16(opt);
                if(ch<1 || ch>5)
                    break;
                switch(ch)
                {
                    case 1:
                        C_1 c_1 = new C_1();
                        c_1.CountFrequency();
                        break;

                    case 3:
                        C_3 c_3 = new C_3();
                        c_3.AgeCalculator();
                        break;
                }
            }while(true);   
        }
    }
}

