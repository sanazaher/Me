using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordStatistics
{
    class FetchFile
    {
        public String fetchDoc()
        {
            
            List<String> files = new List<String>();
            var httpClient = new HttpClient();
            var myTask = httpClient.GetStringAsync("https://www.gutenberg.org/files/45839/45839.txt");
            var myString = myTask.GetAwaiter().GetResult();

            return myString;


        }
    }
}
