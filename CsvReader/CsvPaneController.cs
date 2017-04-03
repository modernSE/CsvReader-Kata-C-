using System.Collections.Generic;
using System.Data;

namespace CsvReader
{
    public class CsvPaneController 
    {
        public DataTable dataTab;
 
        public void initialize()
        {
            dataTab = new DataTable();
        }
        public void addColumn(string caption)
        {

            dataTab.Columns.Add(caption);
        }

        public void addRow(List<string> data)
        {
            var cols = dataTab.Columns.Count;

            var row = dataTab.NewRow();
            for (int i = 0; i < cols; i++)
            {

                row[i] = data[i];

            }

            dataTab.Rows.Add(row);
        }

        private void handleFilter()
        {
            //Todo: Implement
        }

        public void setFilterData(IFilterable filterData)
        {
           //Todo: Implement
        }

    }
}
