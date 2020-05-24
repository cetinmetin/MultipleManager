using MultipleManager.Abstract_Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleManager.Abstract_Factory.Concrete
{
    public class MSSQLFactory : BigFactory
    {
        public override Database CreateSaver()
        {
            return new MSSQL();
        }
    }
}
