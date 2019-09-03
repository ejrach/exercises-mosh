using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndExtensibility
{

    public class DbMigrator
    {
        private readonly ILogger _logger;

        //Dependency injection. using an interface instead of a class.
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);

            // details of migrating the database

            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
}
