using MultipleManager.Abstract_Factory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleManager.Abstract_Factory.Concrete
{
    public class DatabaseManager
    {
        private BigFactory _bigFactory;
        private Database _database;
        public DatabaseManager(BigFactory bigFactory)
        {
            _bigFactory = bigFactory;
            _database = _bigFactory.CreateSaver();
        }
        public void SaveData(string data)
        {
            _database.Save(data);
        }
    }
}
