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
    public class DecoderModelRepository : GenericRepository<DecoderModel>, IDecoderModelRepository
    {
        public DecoderModelRepository(DbContext context)
              : base(context)
        {

        }
    }
}
