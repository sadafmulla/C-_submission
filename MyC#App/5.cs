using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyC_App
{
    public class Response
        {
            public string[] title { get; set; }
            public string[] message { get; set; }
            public string[] type { get; set; }
        }
    class C_5
    {
        

        public void JsonToDict()
        {
            string filePath = @"D:\MyC#App\file.json";
            string jsonString;
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (var streamReader2 = new StreamReader(fileStream, Encoding.UTF8))
            {
                jsonString = streamReader2.ReadToEnd();
            }

            var result = Newtonsoft.Json.JsonConvert.DeserializeObject<Response[]>(jsonString);
            
            

            
          
            foreach (var response in result)
            {

                foreach (var title in response.title)
                {
                    
                    Console.WriteLine("Title : "+title);
                }
                foreach (var message in response.message)
                {
                    
                    Console.WriteLine("Message : "+message);
                }
                foreach (var type in response.type)
                {
                    
                    Console.WriteLine("Type : "+ type);
                }
                

            }
            Console.ReadLine();

             
              
           
    
        }
    }
}

