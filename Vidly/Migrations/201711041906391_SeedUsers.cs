namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [DrivingLicense], [Phone], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8cb04c70-48e7-4027-8bae-cf499c3ce3be', NULL, NULL, N'teste1@inovan.net', 0, N'ACI6mKNZvB/oP9bbY8LgAGIWvkFujPIEL9COBM2YDVw6jtB1rmRkbpMZ97mIvvBygA==', N'4334d028-3c7f-4014-8b7c-cd13f9109dcf', NULL, 0, 0, NULL, 1, 0, N'teste1@inovan.net')
INSERT INTO [dbo].[AspNetUsers] ([Id], [DrivingLicense], [Phone], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a04a8549-07c2-4ff1-9df6-d65fb5a35e07', NULL, NULL, N'admin@inovan.net', 0, N'ADFEN3cpmu32vRJszXY1whIG2/feh09z9tTUdBgSD8ZPSYAIRTflKFWOmXtMEoKaLQ==', N'0bce55a6-0d83-4568-9432-6a8d3b6e552a', NULL, 0, 0, NULL, 1, 0, N'admin@inovan.net')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e8cc5de7-3289-4062-bf3f-71344815f688', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a04a8549-07c2-4ff1-9df6-d65fb5a35e07', N'e8cc5de7-3289-4062-bf3f-71344815f688')
");
        }
        
        public override void Down()
        {
        }
    }
}
