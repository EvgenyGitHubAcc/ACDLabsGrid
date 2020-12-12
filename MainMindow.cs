using System;
using System.Windows.Forms;

namespace ACDGridSharp
{
    public partial class mainWind : Form
    {
        private Container cont = new Container();
        public mainWind()
        {
            InitializeComponent();
        }

        private void createCellsDataGrid()
        {
            for(int i = 0; i < cont.getColCount(); ++i)
            {
                dataGridView.Columns.Add(i.ToString(), i.ToString());
            }
            for (int i = 0; i < cont.FileLineList.Count; ++i)
            {
                dataGridView.Rows.Add(cont.FileLineList[i].getStrArr());
                dataGridView.Rows[i].HeaderCell.Value = i.ToString();
            }
        }

        private void deleteCellsDataGrid()
        {
            dataGridView.Columns.Clear();
        }

        private void savFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDial = new SaveFileDialog();
            saveFileDial.Filter = "Text files(*.result)|*.result";
            if (saveFileDial.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            cont.saveFile(saveFileDial.FileName);
            //cont.saveFile(@"D:\Temp\Prog\ACDGridC#\out.txt");
        }

        private void opnFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDial = new OpenFileDialog();
            openFileDial.Filter = "Text files(*.txt)|*.txt";
            if (openFileDial.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            this.deleteCellsDataGrid();
            cont.loadFile(openFileDial.FileName);
            //cont.loadFile(@"D:\Temp\Prog\ACDGridC#\test.txt");
            cont.sortLines();
            this.createCellsDataGrid();
        }
    }
}
