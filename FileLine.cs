using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACDGridSharp
{
    class FileLine
    {
        private string fileLine = "";
        private List<Element> elemList = new List<Element>();
        public FileLine(string line)
        {
            fileLine = line;
            parceLine();
        }
        public List<Element> ElemList { get => elemList; }
        public string FileLineStr { get => fileLine; }

        private void parceLine()
        {
            string[] elArr = fileLine.Split('\t');
            foreach (string el in elArr)
            {
                elemList.Add(new Element(el));
            }
        }
        private static bool recCompFileLinesLess(FileLine objLeft, FileLine objRight, int index)
        {
            if (objLeft.ElemList[index] < objRight.ElemList[index])
            {
                return true;
            }
            else if (objLeft.ElemList[index] > objRight.ElemList[index])
            {
                return false;
            }
            else
            {
                if (index == objLeft.ElemList.Capacity)
                {
                    return false;
                }
                return recCompFileLinesLess(objLeft, objRight, index + 1);
            }
        }
        public static bool operator <(FileLine objLeft, FileLine objRight)
        {
            return recCompFileLinesLess(objLeft, objRight, 0);
        }
        public static bool operator >(FileLine objLeft, FileLine objRight)
        {
            return !recCompFileLinesLess(objLeft, objRight, 0);
        }
        public static bool operator ==(FileLine objLeft, FileLine objRight)
        {
            return string.Compare(objLeft.FileLineStr, objRight.FileLineStr) == 0;
        }
        public static bool operator !=(FileLine objLeft, FileLine objRight)
        {
            return string.Compare(objLeft.FileLineStr, objRight.FileLineStr) != 0;
        }
        public string[] getStrArr()
        {
            string[] strArr = Array.ConvertAll<Element, string>(this.elemList.ToArray(), Element.ConvertToString);
            return strArr;
        }

    }
    class FileLineByValuesComparer : IComparer<FileLine>
    {
        public int Compare(FileLine objLeft, FileLine objRight)
        {
            if (objLeft == objRight)
            {
                return 0;
            }
            else if (objLeft < objRight)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
