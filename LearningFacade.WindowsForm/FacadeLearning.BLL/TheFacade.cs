using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeLearning.DAL;

namespace FacadeLearning.BLL
{
    public class TheFacade:IDisposable
    {
        private FacadeLearning_DBDataContext _Database;
        public void Dispose()
        {
            _Database.Dispose();
        }

        public TheFacade() //constructor
        {
            _Database = DatabaseHelper.GetData();
        }

        public FacadeLearning_DBDataContext Database
        {
            get
            {
                if (_Database == null)
                {
                    _Database = DatabaseHelper.GetData();
                }
                return _Database;
            }
        }

        public void Insert<T>(T obj) where T : class
        {
            DatabaseHelper.Insert<T>(obj);
        }

    }
}
