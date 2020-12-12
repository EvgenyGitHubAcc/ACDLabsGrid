using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void savFileBtn_Click(object sender, EventArgs e)
        {
            //SaveFileDialog saveFileDial = new SaveFileDialog();
            //if (saveFileDial.ShowDialog() == DialogResult.Cancel)
            //{
            //    return;
            //}
            //cont.saveFile(saveFileDial.FileName);
            cont.saveFile(@"D:\Temp\Prog\ACDGridC#\out.txt");
        }

        private void opnFileBtn_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDial = new OpenFileDialog();
            //if (openFileDial.ShowDialog() == DialogResult.Cancel)
            //{
            //    return;
            //}
            //cont.loadFile(openFileDial.FileName);
            cont.loadFile(@"D:\Temp\Prog\ACDGridC#\test.txt");
            cont.sortLines();
        }
    }
}
