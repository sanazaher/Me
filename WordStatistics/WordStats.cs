using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordStatistics
{
    class WordStats : ITextStatistics
    {
        
       public String chrString { get; set; }    
       public int frequency { get; set; }

        public List<IWordFrequency> Frequencies(int n)
        {
            return new List<IWordFrequency>();
        }

        public List<String> longestWords(int n)
        {
            return new List<String>();
        }
             

        public WordStats (String ChrString, int Frequency)
        {
            chrString = ChrString;
            frequency = Frequency;
        }
        public String CountWord()

        {

           return chrString;

        }
        public int Frequency()
        {
            return frequency;
        }
        
    }
       
}

