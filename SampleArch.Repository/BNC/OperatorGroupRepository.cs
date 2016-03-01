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
    public class OperatorGroupRepository : GenericRepository<OperatorGroup>, IOperatorGroupRepository
    {
        public OperatorGroupRepository(DbContext context)
              : base(context)
        {

        }
    }
}
