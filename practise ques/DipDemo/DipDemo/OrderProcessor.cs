using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipDemo
{
    public class OrderProcessor
    {
        private readonly IDatabase _database;
        public OrderProcessor(IDatabase database)
        {
            _database = database;
        }
        public void Process()
        {
            _database.Save();
        }
    }
}
