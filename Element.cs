using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACDGridSharp
{
    enum TypeEnum : byte
    {
        Int,
        Float,
        String
    }

    class Element
    {
        private string elemStr;
        private dynamic elem;
        private TypeEnum type;
        public Element(string str)
        {
            elemStr = str;
            parceStrToType();
        }
        private void parceStrToType()
        {
            elem = elemStr;
            this.type = TypeEnum.String;
            try
            {
                this.elem = int.Parse(elemStr);
                this.type = TypeEnum.Int;
                return;
            }
            catch (FormatException)
            {

            }
            try
            {
                this.elem = float.Parse(elemStr);
                this.type = TypeEnum.Float;
                return;
            }
            catch (FormatException)
            {

            }
        }
        public static bool operator== (Element objLeft, Element objRight)
        {
            if (objLeft.Type == objRight.Type)
            {
                if (objLeft.Type != TypeEnum.String)
                {
                    return objLeft.Elem == objRight.Elem;
                }
                else
                {
                    if (!string.Compare(objLeft.Elem, objRight.elem))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }
        public static bool operator!= (Element objLeft, Element objRight)
        {
            if (objLeft.Type == objRight.Type)
            {
                if (objLeft.Type != TypeEnum.String)
                {
                    return objLeft.Elem != objRight.Elem;
                }
                else
                {
                    if (string.Compare(objLeft.Elem, objRight.elem))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return true;
            }
        }
        public static bool operator< (Element objLeft, Element objRight)
        {
            if (objLeft.Type == objRight.Type)
            {
                if(objLeft.Type != TypeEnum.String)
                {
                    return objLeft.Elem < objRight.Elem;
                }
                else
                {
                    if(string.Compare(objLeft.Elem, objRight.elem) == -1)
                    {
                        return true;
                    }
                    else if(string.Compare(objLeft.Elem, objRight.elem) == 1)
                    {
                        return false;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                if(objLeft.Type == TypeEnum.String)
                {
                    return true;
                }
                else if(objRight.Type == TypeEnum.String)
                {
                    return false;
                }
                else
                {
                    return objLeft.Elem < objRight.Elem;
                }
            }
        }
        public static bool operator> (Element objLeft, Element objRight)
        {
            if (objLeft.Type == objRight.Type)
            {
                if (objLeft.Type != TypeEnum.String)
                {
                    return objLeft.Elem > objRight.Elem;
                }
                else
                {
                    if (string.Compare(objLeft.Elem, objRight.elem) == -1)
                    {
                        return false;
                    }
                    else if (string.Compare(objLeft.Elem, objRight.elem) == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (objLeft.Type == TypeEnum.String)
                {
                    return false;
                }
                else if (objRight.Type == TypeEnum.String)
                {
                    return true;
                }
                else
                {
                    return objLeft.Elem > objRight.Elem;
                }
            }
        }
        public dynamic Elem { get => elem; }
        public string ElemStr { get => elemStr; }
        public TypeEnum Type { get => type; }
    }
}
