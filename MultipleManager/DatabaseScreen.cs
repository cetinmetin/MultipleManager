using MultipleManager.Abstract_Factory.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleManager
{
    public static class DatabaseScreen
    {
        public static void UI()
        {
            string msSQLData = "", mySQLData = "", oracleData = "";
            string tercih, exitStatus;
            do
            {
                int choice = MainScreen.MultipleChoice(2, "Veri Kaydet", "Kaydedilen Veriyi Görüntüle");
                if (choice == 0)
                {
                    Console.Clear();
                    int database = MainScreen.MultipleChoice(3, "MSSQL", "MySQL", "Oracle");
                    if (database == 0)
                    {
                        Console.Write("Kayıt Edilecek Veriyi Girin: ");
                        msSQLData = Console.ReadLine();
                        DatabaseManager databaseManager = new DatabaseManager(new MSSQLFactory());
                        databaseManager.SaveData(msSQLData);
                    }
                    else if (database == 1)
                    {
                        Console.Write("Kayıt Edilecek Veriyi Girin: ");
                        mySQLData = Console.ReadLine();
                        DatabaseManager databaseManager = new DatabaseManager(new MySQLFactory());
                        databaseManager.SaveData(mySQLData);
                    }
                    else if (database == 2)
                    {
                        Console.Write("Kayıt Edilecek Veriyi Girin: ");
                        oracleData = Console.ReadLine();
                        DatabaseManager databaseManager = new DatabaseManager(new OracleFactory());
                        databaseManager.SaveData(oracleData);
                    }
                }

                Console.Write("Kayıt edilen verileri görüntülemek ister misiniz?(E/H): ");
                tercih = Console.ReadLine();

                if (tercih.ToLower() == "e")
                {
                    Console.WriteLine("MSSQL ile son kayıt edilen veri: {0}", msSQLData);

                    Console.WriteLine("MySQL ile son kayıt edilen veri: {0}", mySQLData);

                    Console.WriteLine("Oracle ile son kayıt edilen veri: {0}", oracleData);

                }
                Console.Write("Ana menüye dönmek istiyor musunuz?(E/H): ");
                exitStatus = Console.ReadLine();
            } while (exitStatus == "h");
        }
    }
}

