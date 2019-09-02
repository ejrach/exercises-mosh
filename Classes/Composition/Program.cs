using System;

namespace Composition
{
    class Program
    {
        //Composition is a kind of relationship between two classes that allow one to contain the other "Has A"
        //Example: a car has an engine
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
