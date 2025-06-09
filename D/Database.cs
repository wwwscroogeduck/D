using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    internal class Database
    {

        //Подлкючение к БД
        public static Entities Instance { get; set; }  = new Entities();

        //Сохранение данных
        public static void save() 
        { 
            Instance.SaveChanges();
        }
    }
}
