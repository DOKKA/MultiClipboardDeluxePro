using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiClipboardDeluxePro.Data
{
    class DBContext : DbContext
    {
        public DbSet<Clip> Clips { get; set; }
    }
}
