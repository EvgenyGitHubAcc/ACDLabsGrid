using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACDGridSharp
{
    class Container
    {
        private List<FileLine> fileLineList = new List<FileLine>();
        private uint linesCount = 0;
        public void parceText(string filepath)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(filepath);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                FileLine fileLine = new FileLine(line);
                this.fileLineList.Add(fileLine);
                ++this.linesCount;
            }
        }
        public void sortLines()
        {
            fileLineList.Sort(new FileLineComparer());
        }
    }
}
