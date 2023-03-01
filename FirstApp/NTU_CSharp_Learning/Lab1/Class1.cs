using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.NTU_CSharp_Learning.Lab1
{
    public class Class1
    {
        private int Id;
        private string Name;

        public Class1(int Idinput, string Nameinput)
        {
            Id = Idinput;
            Name = Nameinput;

        }

        public int GetId()
        {
            return Id;
        }

        public void SetId(int IdNum)
        {
            Id = IdNum;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string Namestr)
        {
            Name = Namestr;
        }


        public override string ToString()
        {
            return "Id=" + Id + ", Name=" + Name ;
        }

    }
}
