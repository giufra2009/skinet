using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
   public interface ISeedData
    {
        Task FillSeedData(string pathUrl, StoreContext context);
    }
}
