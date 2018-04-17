using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Week7Day1HW
{
    class DataBaseContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
