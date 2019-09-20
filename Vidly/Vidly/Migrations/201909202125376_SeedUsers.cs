namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c742eb35-c531-47c5-941a-48eb1f6edadd', N'admin@vidly.com', 0, N'ACVvftnQ8+TQpgQG/eaWQIEXm04DiV/+QuXH1jlTTpHrAzvj2DkAtiqlD8Rf47aE9A==', N'f201881a-74d2-47f7-961c-d5c68688d2c2', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e9687316-67bb-4b9e-8c11-c8ad99c18067', N'guest@vidly.com', 0, N'AKiaJ4c6mkwkB/FLX+nHh+/HtYzQIXxSirJ6COpe/wdH+mpoCjQsEXPNXCS6msXK4A==', N'ce4b9f8d-20c2-478a-8cd4-bc177892928f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd324228a-fa0f-4892-b3d7-2c4e75b99df4', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c742eb35-c531-47c5-941a-48eb1f6edadd', N'd324228a-fa0f-4892-b3d7-2c4e75b99df4')


");


        }
        
        public override void Down()
        {
        }
    }
}
