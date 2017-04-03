using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader
{
    public interface ICsvUi
    {
        void setColumnCount(int amount);

        void addColumn(String caption);

        void addRow(List<String> data);
    }
}
