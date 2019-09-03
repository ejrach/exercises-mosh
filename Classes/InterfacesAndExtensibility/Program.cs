using System;

namespace InterfacesAndExtensibility
{

    

    class Program
    {
        static void Main(string[] args)
        {
            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            //dbMigrator.Migrate();

            var dbMigrator = new DbMigrator(new FileLogger("C:\\temp\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
