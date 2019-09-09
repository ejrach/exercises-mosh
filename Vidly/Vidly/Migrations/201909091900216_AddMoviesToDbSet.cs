namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesToDbSet : DbMigration
    {
        public override void Up()
        {
            //Date in format of: 2017-11-03
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover', 5, 1983-01-01, 1983-01-01, 10)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard', 1, 1983-01-01, 1983-01-01, 8)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Terminator', 1, 1983-01-01, 1983-01-01, 2)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story', 5, 1983-01-01, 1983-01-01, 5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Titanic', 4, 1983-01-01, 1983-01-01, 7)");
        }
        
        public override void Down()
        {
        }
    }
}
