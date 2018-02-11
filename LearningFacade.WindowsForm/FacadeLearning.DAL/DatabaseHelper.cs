using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Linq;
using System.Collections;



namespace FacadeLearning.DAL
{
    public class DatabaseHelper
    {
        private static string ConnectionString = "EntityFrameworkConnectionString";


        public static FacadeLearning_DBDataContext GetData()
        {
            var db = new FacadeLearning_DBDataContext(ConfigurationManager.ConnectionStrings[ConnectionString].ConnectionString);

            return db;
        }

        public static void Insert<T>(T obj) where T : class
        {
            //ArrayList Database = new ArrayList();
            var Database = DatabaseHelper.GetData();
            Database.GetTable<T>().InsertOnSubmit(obj);
            Database.SubmitChanges(ConflictMode.ContinueOnConflict);
        }
        


    }
    
}
