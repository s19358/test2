using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.Models;

namespace test2.Services
{
    public class SqlServerPetDbService : IPetService
    {

        private readonly PetDBContext _dbcontext;
        public SqlServerPetDbService(PetDBContext context)
        {
            _dbcontext = context;
        }
    }
}
