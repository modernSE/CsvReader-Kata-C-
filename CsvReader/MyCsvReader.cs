using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvReader
{
    public class MyCsvReader
    {
        ICsvUi CsvUi;
        List<string> File;
        public void run(string path)
        {
            // ToDo: Logic to implement 
            File = readFile(path);
           
            var captions = extractHeaderLine();
            var cols = captions.Count();
            CsvUi.setColumnCount(cols);

            for (int c = 0; c < cols; c++)
            {
                CsvUi.addColumn(captions[c]);
            }


            var lines = extractBody();

            foreach (var line in lines)
            {
                var lineList = line.ToList();
                CsvUi.addRow(lineList);
            }
            
        }

        public void setCsvUi(ICsvUi csvUi)
        {
           CsvUi = csvUi;
        }


        //ToDo: Methods to implement

        private List<string> readFile(string file)
        {
            return System.IO.File.ReadLines(file).ToList();
        }

        public string[] extractHeaderLine()
        {
            var line = File.First().ToString();
            File.Remove(File.First());
            Char seperator = ',';
            string[] captions = line.Split(seperator);
            return captions;
        }

        public List<string[]> extractBody()
        {
            var linesList = new List<string[]>();
            Char seperator = ',';
            foreach (var line in File)
            {
                string[] splittedLine = line.Split(seperator);
                linesList.Add(splittedLine);
            }

            return linesList;
        }

    }
}
