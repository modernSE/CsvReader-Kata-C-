using System.Collections.Generic;
using System.Windows;


namespace CsvReader
{
    public partial class CsvApplication : Window, ICsvUi
    {

        CsvPaneController csvController;
        MyCsvReader CsvReader;
        int cols;


        public CsvApplication()
        {
            InitializeComponent();
            start();
        }

        public void start()
        {
            string path = "";
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true) path = openFileDialog.FileName;

            CsvReader = new MyCsvReader();
            CsvReader.setCsvUi(this);
            initLayout();
            CsvReader.run(path);
        }

        private void initLayout()
        {
            csvController = new CsvPaneController();
            csvController.initialize();

            myGrid.DataContext = csvController.dataTab.DefaultView;           
        }
        public void addColumn(string caption)
        {
            csvController.addColumn(caption);
            
        }

        public void addRow(List<string> data)
        {   
            csvController.addRow(data);        
        }

        public void setColumnCount(int amount)
        {
            cols = amount;
        }

    }

}
