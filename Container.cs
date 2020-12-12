using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            fileLineList.Sort(new FileLineByValuesComparer());
        }
        public int getColCount()
        {
            int count = 0;
            foreach (FileLine el in fileLineList)
            {
                if(count < el.ElemList.Count)
                {
                    count = el.ElemList.Count;
                }
            }
            return count;
        }
    }
}
