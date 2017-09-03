namespace UniversityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'242f1ee4-9395-41f9-b9ff-54b420888951', N'guest@gmail.com', 0, N'ANe4wUIYttO/xHZRVHybrFmfv0Eh7rUzvimaRmdeKvHTLRY+rqGMWXWVPE2Lcz1KxA==', N'6215f150-7d5f-4c57-bfa5-38a81210952f', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'74d152d1-b99d-433a-8fb8-e24160c41f7f', N'admin@gmail.com', 0, N'ANOtZCV3uT+YlrsdVXFI8XO4QvI0SLrWZ85St70Qwd+D/Iiu1xKERp1ySGx36KNgIQ==', N'a86f7d9f-d70a-4d8b-8212-1358a5e80457', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8e24a2c0-4b52-48b2-a1f3-5e5bd60d4ed8', N'CanManage')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'74d152d1-b99d-433a-8fb8-e24160c41f7f', N'8e24a2c0-4b52-48b2-a1f3-5e5bd60d4ed8')

");
        }
        
        public override void Down()
        {
        }
    }
}
