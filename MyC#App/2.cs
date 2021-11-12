using System;
namespace MyC_App
{
    class C_2
    {
        public void NewText() 
        { 
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            string [] stopwords = {"me","my","myself","we","our","your","his","her","have","has","had","the","!","@","#","$","%","&","*","(",")"};
            foreach (string word in stopwords )
            {
                text = text.Replace(word, " ");
            }
            Console.WriteLine(text);
            return;
        }
    }
}
