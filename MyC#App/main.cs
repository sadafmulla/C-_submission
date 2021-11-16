using System;

namespace MyC_App
{
    class MainClass
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("\nChoose the question no from 1 to 7 : \n (Enter 8 for exit)");
                string opt = Console.ReadLine();
                int ch = Convert.ToInt16(opt);
                if(ch<1 || ch>7)
                    break;
                switch(ch)
                {
                    case 1:
                        C_1 c_1 = new C_1();
                        c_1.CountFrequency();
                        break;

                    case 2:
                        C_2 c_2 = new C_2();
                        c_2.NewText();
                        break;

                    case 3:
                        C_3 c_3 = new C_3();
                        c_3.AgeCalculator();
                        break;

                    case 4:
                        C_4 c_4 = new C_4();
                        c_4.StoreDictionary();
                        break;

                    case 5:
                        C_5 c_5 = new C_5();
                        c_5.JsonToDict();
                        break;

                    case 6:
                        C_6 c_6 = new C_6();
                        c_6.Search();
                        break;

                    case 7:
                        C_7 c_7 = new C_7();
                        c_7.IntToFloat();
                        break;
                }
            }while(true);   
        }
    }
}

