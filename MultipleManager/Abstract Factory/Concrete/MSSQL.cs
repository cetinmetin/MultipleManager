using MultipleManager.Abstract_Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleManager.Abstract_Factory.Concrete
{
    public class MSSQL : Database
    {
        public override void Save(string data)
        {
            Console.WriteLine("{0} verisi MSSQL ile kayıt edildi",data);
        }
    }
}
