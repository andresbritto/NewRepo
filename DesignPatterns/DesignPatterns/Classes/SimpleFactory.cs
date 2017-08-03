using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Classes
{
    class SimpleFactory
    {
        public SimpleFactory() { }

        public Namer getName (string name)
        {
            int i = name.IndexOf(",");
            if (i > 0)
                return new LastFirst(name);
            else
                return new FirstFirst(name);

        }
    }

    public class Namer
    {
        protected string fName, lName;

        public string getFName()
        {
            return fName;
        }

        public string getLName()
        {
            return lName;
        }
    }

    public class FirstFirst : Namer
    {
        public  FirstFirst (string name)
        {
            int i = name.IndexOf(" ");
            if (i > 0)
            {
                fName = name.Substring(0, i).Trim();
                lName = name.Substring(i + 1).Trim();
            }
            else
            {
                lName = name;
                fName = "";
            }
        }
    }

    public class LastFirst : Namer
    {
        public LastFirst (string name)
        {
            int i = name.IndexOf(",");
            if (i > 0)
            {
                lName = name.Substring(0, i);
                fName = name.Substring(i + 1).Trim();
            }
            else
            {
                lName = name;
                fName = "";
            }
        }
    }
}
