using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordStatistics;

namespace WordStatistics
{
    interface ITextStatistics : IWordFrequency
    {
        List<IWordFrequency> Frequencies(int n);

        List<String> longestWords(int n);


    }
}

