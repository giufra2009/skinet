using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
  public abstract  class SeedDataFactory
    {
        protected abstract ISeedData SeedData();
        public ISeedData FillSeedData()
        {
            return this.SeedData();
        }

         
    }
}
