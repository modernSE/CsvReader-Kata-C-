using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader
{
    public interface IFilterable
    {
        List<List<String>> Filter(int col, String word);

    }
}
