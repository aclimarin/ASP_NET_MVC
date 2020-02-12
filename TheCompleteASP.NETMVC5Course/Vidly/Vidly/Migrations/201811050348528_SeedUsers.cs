namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'19798f33-f3ad-48c4-ab5b-30443062b3db', N'guest@vidly.com', 0, N'AG0pVS7Ne5GPhF6m81p4yszEO99PxFbRX9PhNYOSJ3NetLzgc8qv3U8xaDh53tcmeA==', N'62e3c5ff-caaf-42f0-87eb-76fe8148dcf5', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bfe1c46a-6923-4bf3-a5a3-f2cbd046b775', N'admin@vidly.com', 0, N'AKp8mIj3cxj1m5O5S/Wsmpiw5FB25ratyPQ0mcHVaZNGVDaO0SJdiYIGW8csR95grQ==', N'2a81272e-d17c-4964-89dc-60c9d567b94c', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3d74173c-bbeb-4ae7-82d6-304c94cb1290', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bfe1c46a-6923-4bf3-a5a3-f2cbd046b775', N'3d74173c-bbeb-4ae7-82d6-304c94cb1290')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
