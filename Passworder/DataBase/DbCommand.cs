using Passworder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.DataContracts;
using System.Text;
using System.Threading.Tasks;

namespace Passworder.DataBase
{
    public class DbCommand
    {
        public DbCommand()
        {
            dbContext = new ApplicationDbContext();
        }

        ApplicationDbContext dbContext;

        public bool AddDataInDb(DataFilling dataFilling)
        {
            dbContext.DataFillings.Add(dataFilling);
            dbContext.SaveChanges();
            return true;
        }
        
        public bool RemoveDataInDb(DataFilling dataFilling)
        {
            dbContext.DataFillings.Remove(dataFilling);
            dbContext.SaveChanges();
            return true;
        }

        public IEnumerable<DataFilling> GetData()
        {
            var data = dbContext.DataFillings;
            return data;
        }

        public bool UpdateDataInDb(DataFilling dataFilling)
        {
            dbContext.DataFillings.Update(dataFilling);
            dbContext.SaveChanges();
            return true;
        }
    }
}
