using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TableMates.Models;

namespace TableMates.DAL
{
    public class TableMatesInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TablematesContext>
    {
        protected override void Seed(TablematesContext context)
        {
            //put database seed data in here
        }
    }
}