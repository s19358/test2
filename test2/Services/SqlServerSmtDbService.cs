using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.Models;

namespace test2.Services
{
    public class SqlServerSmtDbService : ISmtDbService
    {

        private readonly PetDBContext _dbcontext;
        public SqlServerSmtDbService(PetDBContext context)
        {
            _dbcontext = context;
        }
    }
}
