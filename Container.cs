using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACDGridSharp
{
    class Container
    {
        private List<FileLine> fileLineList = new List<FileLine>();
        public List<FileLine> FileLineList { get => fileLineList; }
        public void loadFile(string filepath)
        {
            this.fileLineList.Clear();
            System.IO.StreamReader file = new System.IO.StreamReader(filepath);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                FileLine fileLine = new FileLine(line);
                this.fileLineList.Add(fileLine);
            }
        }
        public void saveFile(string filepath)
        {
            using (StreamWriter file = new StreamWriter(filepath, false, System.Text.Encoding.Default))
            {
                foreach (FileLine el in fileLineList)
                {
                    file.WriteLine(el.FileLineStr);
                }
            }
        }
        public void sortLines()
        {
            if (checkEqLineLength())
            {
                fileLineList.Sort(new FileLineByValuesComparer());
            }
            else
            {
                MessageBox.Show("The lines length differs. Sort aborted.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        public int getColCount()
        {
            int count = 0;
            foreach (FileLine el in fileLineList)
            {
                if (count < el.ElemList.Count)
                {
                    count = el.ElemList.Count;
                }
            }
            return count;
        }
        private bool checkEqLineLength()
        {
            for (int i = 0; i < fileLineList.Count - 1; ++i)
            {
                if (fileLineList[i].ElemList.Count == fileLineList[i + 1].ElemList.Count)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
