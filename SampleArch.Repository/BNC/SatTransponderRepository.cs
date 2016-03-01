using SampleArch.Model;
using SampleArch.Repository.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Repository
{
    public class SatTransponderRepository : GenericRepository<SatTransponder>, ISatTransponderRepository
    {
        public SatTransponderRepository(DbContext context)
              : base(context)
        {

        }
    }
}
