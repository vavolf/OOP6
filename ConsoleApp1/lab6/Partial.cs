using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    sealed public partial class Check : Document
    {
        public override void Store()
        {
            Console.WriteLine("Этот документ хранится в стопке");
        }
        public override string ToString() => base.ToString() + $", тип документа – {this.DocType}";
    }
}
