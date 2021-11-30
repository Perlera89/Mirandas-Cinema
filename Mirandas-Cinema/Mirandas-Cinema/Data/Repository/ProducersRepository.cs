using Mirandas_Cinema.Data.Base;
using Mirandas_Cinema.Data.Services;
using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data.Repository
{
    public class ProducerRepository : EntityBaseRepository<Producer>, IProducer
    {
        public ProducerRepository(AppDbContext appDb) : base(appDb)
        {


        }

    }
}
