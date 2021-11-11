using System;
namespace MyC_App
{
    class C_1
    {
        public void CountFrequency()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            string [] stopwords = {"i","me","my","myself","we","our","your","his","her","have","has","had","the","an","a","!","@","#","$","%","&","*","(",")"};
            
            string [] splitText = text.Split(' ');
            int count = 0;
            for ( int i=0; i<splitText.Length ;i++)
            {
                for( int j=0; j<stopwords.Length; j++)
                {
                    if(word.Equals(stopwords[j]))
                    {
                        Console.WriteLine("Not applicable");
                        return;
                    }   
                }
                
                if(word.Equals(splitText[i]))
                    count ++;
            }
            Console.Write("\nThe word occured " + count + " times");
            return;
        }
    }
}

