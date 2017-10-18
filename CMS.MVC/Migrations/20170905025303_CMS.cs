using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CMS.MVC.Migrations
{
    public partial class CMS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bairong_Area",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AreaName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ChildrenCount = table.Column<int>(type: "int", nullable: true),
                    CountOfAdmin = table.Column<int>(type: "int", nullable: true),
                    IsLastNode = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    ParentsCount = table.Column<int>(type: "int", nullable: true),
                    ParentsPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_Area", x => x.AreaId);
                });

            migrationBuilder.CreateTable(
                name: "bairong_ContentCheck",
                columns: table => new
                {
                    CheckId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CheckDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckedLevel = table.Column<int>(type: "int", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    IsAdmin = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsChecked = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    NodeId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Reasons = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TableName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_ContentCheck", x => x.CheckId);
                });

            migrationBuilder.CreateTable(
                name: "bairong_ContentModel",
                columns: table => new
                {
                    ModelId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IconUrl = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsSystem = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    ModelName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TableName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TableType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_ContentModel", x => new { x.ModelId, x.SiteId });
                });

            migrationBuilder.CreateTable(
                name: "bairong_Count",
                columns: table => new
                {
                    CountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountNum = table.Column<int>(type: "int", nullable: true),
                    CountType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RelatedIdentity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RelatedTableName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_Count", x => x.CountId);
                });

            migrationBuilder.CreateTable(
                name: "bairong_DbCache",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CacheKey = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CacheValue = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_DbCache", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bairong_Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChildrenCount = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CountOfAdmin = table.Column<int>(type: "int", nullable: true),
                    DepartmentName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsLastNode = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    ParentsCount = table.Column<int>(type: "int", nullable: true),
                    ParentsPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_Department", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "bairong_Digg",
                columns: table => new
                {
                    DiggId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bad = table.Column<int>(type: "int", nullable: true),
                    Good = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    RelatedIdentity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_Digg", x => x.DiggId);
                });

            migrationBuilder.CreateTable(
                name: "bairong_ErrorLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Stacktrace = table.Column<string>(type: "ntext", nullable: true),
                    Summary = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_ErrorLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bairong_Log",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Action = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bairong_PermissionsInRoles",
                columns: table => new
                {
                    RoleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GeneralPermissions = table.Column<string>(type: "text", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_PermissionsInRoles", x => x.RoleName);
                });

            migrationBuilder.CreateTable(
                name: "bairong_TableCollection",
                columns: table => new
                {
                    TableEnName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    AttributeNum = table.Column<int>(type: "int", nullable: true),
                    AuxiliaryTableType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    IsChangedAfterCreatedInDb = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsCreatedInDb = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsDefault = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    TableCnName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_TableCollection", x => x.TableEnName);
                });

            migrationBuilder.CreateTable(
                name: "bairong_TableMatch",
                columns: table => new
                {
                    TableMatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ColumnsMap = table.Column<string>(type: "ntext", nullable: true),
                    ConnectionString = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ConnectionStringToMatch = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TableName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TableNameToMatch = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_TableMatch", x => x.TableMatchId);
                });

            migrationBuilder.CreateTable(
                name: "bairong_TableStyle",
                columns: table => new
                {
                    TableStyleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttributeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DefaultValue = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ExtendValues = table.Column<string>(type: "ntext", nullable: true),
                    HelpText = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    InputType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsHorizontal = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsRequired = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsSingleLine = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsVisible = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsVisibleInList = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    RelatedIdentity = table.Column<int>(type: "int", nullable: true),
                    TableName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_TableStyle", x => x.TableStyleId);
                });

            migrationBuilder.CreateTable(
                name: "bairong_Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentIdCollection = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Tag = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UseNum = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "bairong_ThirdLogin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsEnabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    SettingsXml = table.Column<string>(type: "ntext", nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true),
                    ThirdLoginName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ThirdLoginType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_ThirdLogin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bairong_UserBinding",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ThirdLoginType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ThirdLoginUserId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_UserBinding", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "bairong_UserGroup",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ExtendValues = table.Column<string>(type: "ntext", nullable: true),
                    GroupName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDefault = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_UserGroup", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "bairong_UserLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Action = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_UserLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bairong_Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AvatarUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Birthday = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CountOfFailedLogin = table.Column<int>(type: "int", nullable: true),
                    CountOfLogin = table.Column<int>(type: "int", nullable: true),
                    CountOfWriting = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Education = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ExtendValues = table.Column<string>(type: "ntext", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Graduation = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    Interests = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsChecked = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsLockedOut = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    LastActivityDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastResetPasswordDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Organization = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PasswordFormat = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Position = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Qq = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Signature = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WeiBo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WeiXin = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "model_Content",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Author = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CheckedLevel = table.Column<int>(type: "int", nullable: true),
                    Comments = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    ContentGroupNameCollection = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FileUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Hits = table.Column<int>(type: "int", nullable: true),
                    HitsByDay = table.Column<int>(type: "int", nullable: true),
                    HitsByMonth = table.Column<int>(type: "int", nullable: true),
                    HitsByWeek = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsChecked = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsColor = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsHot = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsRecommend = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsTop = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    LastEditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastEditUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LastHitsDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LinkUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NodeID = table.Column<int>(type: "int", nullable: true),
                    Photos = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemID = table.Column<int>(type: "int", nullable: true),
                    ReferenceID = table.Column<int>(type: "int", nullable: true),
                    SettingsXML = table.Column<string>(type: "ntext", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SourceID = table.Column<int>(type: "int", nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Summary = table.Column<string>(type: "ntext", nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VideoUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    WritingUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_model_Content", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "model_Job",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CheckedLevel = table.Column<int>(type: "int", nullable: true),
                    Comments = table.Column<int>(type: "int", nullable: true),
                    ContentGroupNameCollection = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Department = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Hits = table.Column<int>(type: "int", nullable: true),
                    HitsByDay = table.Column<int>(type: "int", nullable: true),
                    HitsByMonth = table.Column<int>(type: "int", nullable: true),
                    HitsByWeek = table.Column<int>(type: "int", nullable: true),
                    IsChecked = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsTop = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsUrgent = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    LastEditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastEditUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LastHitsDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NodeID = table.Column<int>(type: "int", nullable: true),
                    NumberOfPeople = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Photos = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemID = table.Column<int>(type: "int", nullable: true),
                    ReferenceID = table.Column<int>(type: "int", nullable: true),
                    Requirement = table.Column<string>(type: "ntext", nullable: true),
                    Responsibility = table.Column<string>(type: "ntext", nullable: true),
                    SettingsXML = table.Column<string>(type: "ntext", nullable: true),
                    SourceID = table.Column<int>(type: "int", nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WritingUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_model_Job", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "model_Vote",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CheckedLevel = table.Column<int>(type: "int", nullable: true),
                    Comments = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    ContentGroupNameCollection = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HiddenContent = table.Column<string>(type: "ntext", nullable: true),
                    Hits = table.Column<int>(type: "int", nullable: true),
                    HitsByDay = table.Column<int>(type: "int", nullable: true),
                    HitsByMonth = table.Column<int>(type: "int", nullable: true),
                    HitsByWeek = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsChecked = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsClosed = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsImageVote = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsSummary = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsTop = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsVotedView = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    LastEditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastEditUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LastHitsDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaxSelectNum = table.Column<int>(type: "int", nullable: true),
                    NodeID = table.Column<int>(type: "int", nullable: true),
                    Participants = table.Column<int>(type: "int", nullable: true),
                    Photos = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemID = table.Column<int>(type: "int", nullable: true),
                    ReferenceID = table.Column<int>(type: "int", nullable: true),
                    SettingsXML = table.Column<string>(type: "ntext", nullable: true),
                    SourceID = table.Column<int>(type: "int", nullable: true),
                    SubTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Summary = table.Column<string>(type: "ntext", nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WritingUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_model_Vote", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "model_WCM_GovInteract",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CardNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CardType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CheckedLevel = table.Column<int>(type: "int", nullable: true),
                    Comments = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    ContentGroupNameCollection = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: true),
                    DepartmentName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Fax = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FileUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Hits = table.Column<int>(type: "int", nullable: true),
                    HitsByDay = table.Column<int>(type: "int", nullable: true),
                    HitsByMonth = table.Column<int>(type: "int", nullable: true),
                    HitsByWeek = table.Column<int>(type: "int", nullable: true),
                    IPAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsChecked = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsPublic = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsRecommend = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsTop = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    LastEditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastEditUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LastHitsDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NodeID = table.Column<int>(type: "int", nullable: true),
                    Organization = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Phone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Photos = table.Column<int>(type: "int", nullable: true),
                    PostCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PublishmentSystemID = table.Column<int>(type: "int", nullable: true),
                    QueryCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RealName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ReferenceID = table.Column<int>(type: "int", nullable: true),
                    SettingsXML = table.Column<string>(type: "ntext", nullable: true),
                    SourceID = table.Column<int>(type: "int", nullable: true),
                    State = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TypeID = table.Column<int>(type: "int", nullable: true),
                    WritingUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_model_WCM_GovInteract", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "model_WCM_GovPublic",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AbolitionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Category1ID = table.Column<int>(type: "int", nullable: true),
                    Category2ID = table.Column<int>(type: "int", nullable: true),
                    Category3ID = table.Column<int>(type: "int", nullable: true),
                    Category4ID = table.Column<int>(type: "int", nullable: true),
                    Category5ID = table.Column<int>(type: "int", nullable: true),
                    Category6ID = table.Column<int>(type: "int", nullable: true),
                    CheckedLevel = table.Column<int>(type: "int", nullable: true),
                    Comments = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    ContentGroupNameCollection = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    DocumentNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EffectDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FileUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Hits = table.Column<int>(type: "int", nullable: true),
                    HitsByDay = table.Column<int>(type: "int", nullable: true),
                    HitsByMonth = table.Column<int>(type: "int", nullable: true),
                    HitsByWeek = table.Column<int>(type: "int", nullable: true),
                    Identifier = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsAbolition = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsChecked = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsColor = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsHot = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsRecommend = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsTop = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    Keywords = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LastEditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastEditUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LastHitsDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NodeID = table.Column<int>(type: "int", nullable: true),
                    Photos = table.Column<int>(type: "int", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PublishmentSystemID = table.Column<int>(type: "int", nullable: true),
                    ReferenceID = table.Column<int>(type: "int", nullable: true),
                    SettingsXML = table.Column<string>(type: "ntext", nullable: true),
                    SourceID = table.Column<int>(type: "int", nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WritingUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_model_WCM_GovPublic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_AdArea",
                columns: table => new
                {
                    AdAreaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdAreaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: true),
                    IsEnabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Width = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_AdArea", x => x.AdAreaId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_Advertisement",
                columns: table => new
                {
                    AdvertisementName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: false),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdvertisementType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FileTemplateIdCollection = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDateLimited = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    NavigationUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    NodeIdCollectionToChannel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NodeIdCollectionToContent = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Settings = table.Column<string>(type: "ntext", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_Advertisement", x => new { x.AdvertisementName, x.PublishmentSystemId });
                });

            migrationBuilder.CreateTable(
                name: "siteserver_AdvImageClassify",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChildrenCount = table.Column<int>(type: "int", nullable: true),
                    ContentNum = table.Column<int>(type: "int", nullable: true),
                    Enabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsLastItem = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    ItemIndexName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    ParentsCount = table.Column<int>(type: "int", nullable: true),
                    ParentsPath = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_AdvImageClassify", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_AdvImageContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdvImageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdvImagePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ClassifyId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsChecked = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    LaseEditUser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastEditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    SettingsXml = table.Column<string>(type: "ntext", nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_AdvImageContent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    GoodCount = table.Column<int>(type: "int", nullable: true),
                    IsChecked = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    NodeId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_Comment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_ContentGroup",
                columns: table => new
                {
                    ContentGroupName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_ContentGroup", x => new { x.ContentGroupName, x.PublishmentSystemId });
                });

            migrationBuilder.CreateTable(
                name: "siteserver_CreateTask",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChannelId = table.Column<int>(type: "int", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    CreateType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    TemplateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_CreateTask", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_CreateTaskLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChannelId = table.Column<int>(type: "int", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    CreateType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ErrorMessage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsSuccess = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    TaskName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TemplateId = table.Column<int>(type: "int", nullable: true),
                    TimeSpan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_CreateTaskLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_GatherDatabaseRule",
                columns: table => new
                {
                    GatherRuleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: false),
                    ConnectionString = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    GatherNum = table.Column<int>(type: "int", nullable: true),
                    IsAutoCreate = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsChecked = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsOrderByDesc = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    LastGatherDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NodeId = table.Column<int>(type: "int", nullable: true),
                    RelatedIdentity = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    RelatedOrderBy = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    RelatedTableName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    TableMatchId = table.Column<int>(type: "int", nullable: true),
                    WhereString = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_GatherDatabaseRule", x => new { x.GatherRuleName, x.PublishmentSystemId });
                });

            migrationBuilder.CreateTable(
                name: "siteserver_GatherFileRule",
                columns: table => new
                {
                    GatherRuleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: false),
                    Charset = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContentAttributes = table.Column<string>(type: "ntext", nullable: true),
                    ContentAttributesXml = table.Column<string>(type: "ntext", nullable: true),
                    ContentContentEnd = table.Column<string>(type: "ntext", nullable: true),
                    ContentContentStart = table.Column<string>(type: "ntext", nullable: true),
                    ContentExclude = table.Column<string>(type: "ntext", nullable: true),
                    ContentHtmlClearCollection = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContentHtmlClearTagCollection = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContentTitleEnd = table.Column<string>(type: "ntext", nullable: true),
                    ContentTitleStart = table.Column<string>(type: "ntext", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GatherUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImageDirectoryPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsAutoCreate = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsChecked = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsRemoveScripts = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsSaveImage = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsSaveRelatedFiles = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsToFile = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    LastGatherDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NodeId = table.Column<int>(type: "int", nullable: true),
                    ScriptDirectoryPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StyleDirectoryPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_GatherFileRule", x => new { x.GatherRuleName, x.PublishmentSystemId });
                });

            migrationBuilder.CreateTable(
                name: "siteserver_GatherRule",
                columns: table => new
                {
                    GatherRuleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: false),
                    Charset = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContentAttributes = table.Column<string>(type: "ntext", nullable: true),
                    ContentAttributesXml = table.Column<string>(type: "ntext", nullable: true),
                    ContentChannelEnd = table.Column<string>(type: "ntext", nullable: true),
                    ContentChannelStart = table.Column<string>(type: "ntext", nullable: true),
                    ContentContentEnd = table.Column<string>(type: "ntext", nullable: true),
                    ContentContentStart = table.Column<string>(type: "ntext", nullable: true),
                    ContentExclude = table.Column<string>(type: "ntext", nullable: true),
                    ContentHtmlClearCollection = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContentHtmlClearTagCollection = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContentNextPageEnd = table.Column<string>(type: "ntext", nullable: true),
                    ContentNextPageStart = table.Column<string>(type: "ntext", nullable: true),
                    ContentTitleEnd = table.Column<string>(type: "ntext", nullable: true),
                    ContentTitleStart = table.Column<string>(type: "ntext", nullable: true),
                    CookieString = table.Column<string>(type: "text", unicode: false, nullable: true),
                    ExtendValues = table.Column<string>(type: "ntext", nullable: true),
                    GatherUrlCollection = table.Column<string>(type: "text", unicode: false, nullable: true),
                    GatherUrlIsCollection = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    GatherUrlIsSerialize = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    GatherUrlSerialize = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    LastGatherDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ListAreaEnd = table.Column<string>(type: "ntext", nullable: true),
                    ListAreaStart = table.Column<string>(type: "ntext", nullable: true),
                    NodeId = table.Column<int>(type: "int", nullable: true),
                    SerializeFrom = table.Column<int>(type: "int", nullable: true),
                    SerializeInterval = table.Column<int>(type: "int", nullable: true),
                    SerializeIsAddZero = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    SerializeIsOrderByDesc = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    SerializeTo = table.Column<int>(type: "int", nullable: true),
                    TitleInclude = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UrlInclude = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_GatherRule", x => new { x.GatherRuleName, x.PublishmentSystemId });
                });

            migrationBuilder.CreateTable(
                name: "siteserver_InnerLink",
                columns: table => new
                {
                    InnerLinkName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: false),
                    LinkUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_InnerLink", x => new { x.InnerLinkName, x.PublishmentSystemId });
                });

            migrationBuilder.CreateTable(
                name: "siteserver_Input",
                columns: table => new
                {
                    InputId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InputName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsChecked = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsReply = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    SettingsXml = table.Column<string>(type: "ntext", nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_Input", x => x.InputId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_Keyword",
                columns: table => new
                {
                    KeywordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Alternative = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_Keyword", x => x.KeywordId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_Log",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Action = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChannelId = table.Column<int>(type: "int", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    IpAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_MenuDisplay",
                columns: table => new
                {
                    MenuDisplayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BgColor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ChildMenuIcon = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    FontColor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FontColorHilite = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FontFamily = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    FontSize = table.Column<int>(type: "int", nullable: true),
                    FontStyle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FontWeight = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    HideOnMouseOut = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    HideTimeout = table.Column<int>(type: "int", nullable: true),
                    IsDefault = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    MenuBgOpaque = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MenuBorder = table.Column<int>(type: "int", nullable: true),
                    MenuBorderBgColor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MenuDisplayName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MenuHiliteBgColor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MenuItemBgColor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MenuItemHAlign = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MenuItemHeight = table.Column<int>(type: "int", nullable: true),
                    MenuItemIndent = table.Column<int>(type: "int", nullable: true),
                    MenuItemPadding = table.Column<int>(type: "int", nullable: true),
                    MenuItemSpacing = table.Column<int>(type: "int", nullable: true),
                    MenuItemVAlign = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MenuLiteBgColor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MenuWidth = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Vertical = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    XPosition = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    YPosition = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_MenuDisplay", x => x.MenuDisplayId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_Node",
                columns: table => new
                {
                    NodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChannelFilePathRule = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ChannelTemplateId = table.Column<int>(type: "int", nullable: true),
                    ChildrenCount = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    ContentFilePathRule = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ContentModelId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ContentNum = table.Column<int>(type: "int", nullable: true),
                    ContentTemplateId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ExtendValues = table.Column<string>(type: "ntext", nullable: true),
                    FilePath = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsLastNode = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    Keywords = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LinkType = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    LinkUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    NodeGroupNameCollection = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NodeIndexName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NodeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NodeType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    ParentsCount = table.Column<int>(type: "int", nullable: true),
                    ParentsPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_Node", x => x.NodeId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_NodeGroup",
                columns: table => new
                {
                    NodeGroupName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_NodeGroup", x => new { x.NodeGroupName, x.PublishmentSystemId });
                });

            migrationBuilder.CreateTable(
                name: "siteserver_Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    LargeUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    MiddleUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    SmallUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_Photo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_PluginConfig",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConfigName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ConfigValue = table.Column<string>(type: "ntext", nullable: true),
                    PluginId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SiteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_PluginConfig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_PublishmentSystem",
                columns: table => new
                {
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: false),
                    AuxiliaryTableForContent = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AuxiliaryTableForGovInteract = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AuxiliaryTableForGovPublic = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AuxiliaryTableForJob = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AuxiliaryTableForVote = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CheckContentLevel = table.Column<int>(type: "int", nullable: true),
                    IsCheckContentUseLevel = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsHeadquarters = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    ParentPublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemDir = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PublishmentSystemName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PublishmentSystemType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PublishmentSystemUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    SettingsXml = table.Column<string>(type: "ntext", nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_PublishmentSystem", x => x.PublishmentSystemId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_RelatedField",
                columns: table => new
                {
                    RelatedFieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Prefixes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    RelatedFieldName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Suffixes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TotalLevel = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_RelatedField", x => x.RelatedFieldId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_ResumeContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AvailabelTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Birthday = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Cer_CertificationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cer_Count = table.Column<int>(type: "int", nullable: true),
                    Cer_EffectiveDate = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Edu_Count = table.Column<int>(type: "int", nullable: true),
                    Edu_Education = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Edu_FromMonth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Edu_FromYear = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Edu_Profession = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Edu_SchoolName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Edu_Summary = table.Column<string>(type: "ntext", nullable: true),
                    Edu_ToMonth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Edu_ToYear = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Education = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Exp_Count = table.Column<int>(type: "int", nullable: true),
                    Exp_Department = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Exp_EmployerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Exp_EmployerPhone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Exp_FromMonth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Exp_FromYear = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Exp_Industry = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Exp_PositionTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Exp_Score = table.Column<string>(type: "ntext", nullable: true),
                    Exp_Summary = table.Column<string>(type: "ntext", nullable: true),
                    Exp_ToMonth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Exp_ToYear = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Exp_WorkPlace = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ExpectSalary = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HomePhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdCardNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdCardType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsView = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    JobContentId = table.Column<int>(type: "int", nullable: true),
                    Lan_Count = table.Column<int>(type: "int", nullable: true),
                    Lan_Language = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Lan_Level = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LastSchoolName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Marriage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MobilePhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Pro_Count = table.Column<int>(type: "int", nullable: true),
                    Pro_FromMonth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Pro_FromYear = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Pro_ProjectName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Pro_Summary = table.Column<string>(type: "ntext", nullable: true),
                    Pro_ToMonth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Pro_ToYear = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Profession = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    RealName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ski_Ability = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ski_Count = table.Column<int>(type: "int", nullable: true),
                    Ski_SkillName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ski_UsedTimes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Tra_Centification = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Tra_Count = table.Column<int>(type: "int", nullable: true),
                    Tra_FromMonth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tra_FromYear = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tra_Lesson = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Tra_Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Tra_ToMonth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tra_ToYear = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Tra_TrainerAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Tra_TrainerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WorkYear = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_ResumeContent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_SeoMeta",
                columns: table => new
                {
                    SeoMetaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Author = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Charset = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Copyright = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Distribution = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Expires = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsDefault = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    Keywords = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Language = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PageTitle = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Rating = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RevisitAfter = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Robots = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SeoMetaName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_SeoMeta", x => x.SeoMetaId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_SeoMetasInNodes",
                columns: table => new
                {
                    NodeId = table.Column<int>(type: "int", nullable: false),
                    IsChannel = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: false),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    SeoMetaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_SeoMetasInNodes", x => new { x.NodeId, x.IsChannel });
                    table.UniqueConstraint("AK_siteserver_SeoMetasInNodes_IsChannel_NodeId_SeoMetaId", x => new { x.IsChannel, x.NodeId, x.SeoMetaId });
                });

            migrationBuilder.CreateTable(
                name: "siteserver_SigninLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    IpAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsSignin = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    SigninDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_SigninLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_SigninSetting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    EndDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsGroup = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsSignin = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    NodeId = table.Column<int>(type: "int", nullable: true),
                    Priority = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    SigninDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserGroupCollection = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    UserNameCollection = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_SigninSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_SigninUserContentId",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentIdCollection = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    IsGroup = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    NodeId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_SigninUserContentId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_Star",
                columns: table => new
                {
                    StarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChannelId = table.Column<int>(type: "int", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Point = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_Star", x => x.StarId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_StarSetting",
                columns: table => new
                {
                    StarSettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChannelId = table.Column<int>(type: "int", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    PointAverage = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    TotalCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_StarSetting", x => x.StarSettingId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_StlTag",
                columns: table => new
                {
                    TagName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: false),
                    TagContent = table.Column<string>(type: "ntext", nullable: true),
                    TagDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_StlTag", x => new { x.TagName, x.PublishmentSystemId });
                    table.UniqueConstraint("AK_siteserver_StlTag_PublishmentSystemId_TagName", x => new { x.PublishmentSystemId, x.TagName });
                });

            migrationBuilder.CreateTable(
                name: "siteserver_SystemPermissions",
                columns: table => new
                {
                    RoleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: false),
                    ChannelPermissions = table.Column<string>(type: "text", unicode: false, nullable: true),
                    NodeIdCollection = table.Column<string>(type: "text", unicode: false, nullable: true),
                    WebsitePermissions = table.Column<string>(type: "text", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_SystemPermissions", x => new { x.RoleName, x.PublishmentSystemId });
                    table.UniqueConstraint("AK_siteserver_SystemPermissions_PublishmentSystemId_RoleName", x => new { x.PublishmentSystemId, x.RoleName });
                });

            migrationBuilder.CreateTable(
                name: "siteserver_TagStyle",
                columns: table => new
                {
                    StyleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentTemplate = table.Column<string>(type: "ntext", nullable: true),
                    ElementName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FailureTemplate = table.Column<string>(type: "ntext", nullable: true),
                    IsTemplate = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    ScriptTemplate = table.Column<string>(type: "ntext", nullable: true),
                    SettingsXml = table.Column<string>(type: "ntext", nullable: true),
                    StyleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StyleTemplate = table.Column<string>(type: "ntext", nullable: true),
                    SuccessTemplate = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_TagStyle", x => x.StyleId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_Task",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FrequencyType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsEnabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsSystemTask = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    LastExecuteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OnlyOnceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PeriodIntervalMinute = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    ServiceParameters = table.Column<string>(type: "ntext", nullable: true),
                    ServiceType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StartDay = table.Column<int>(type: "int", nullable: true),
                    StartHour = table.Column<int>(type: "int", nullable: true),
                    StartWeekday = table.Column<int>(type: "int", nullable: true),
                    TaskName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_Task", x => x.TaskId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_Template",
                columns: table => new
                {
                    TemplateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Charset = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedFileExtName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedFileFullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDefault = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    RelatedFileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TemplateName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TemplateType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_Template", x => x.TemplateId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_TemplateLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContentLength = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    TemplateContent = table.Column<string>(type: "ntext", nullable: true),
                    TemplateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_TemplateLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_TemplateMatch",
                columns: table => new
                {
                    NodeId = table.Column<int>(type: "int", nullable: false),
                    ChannelFilePathRule = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ChannelTemplateId = table.Column<int>(type: "int", nullable: true),
                    ContentFilePathRule = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ContentTemplateId = table.Column<int>(type: "int", nullable: true),
                    FilePath = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_TemplateMatch", x => x.NodeId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_Tracking",
                columns: table => new
                {
                    TrackingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccessDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Browser = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IpAddress = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    LastAccessDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OperatingSystem = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PageContentId = table.Column<int>(type: "int", nullable: true),
                    PageNodeId = table.Column<int>(type: "int", nullable: true),
                    PageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Referrer = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TrackerType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_Tracking", x => x.TrackingId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_VoteOperation",
                columns: table => new
                {
                    OperationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    IpAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NodeId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_VoteOperation", x => x.OperationId);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_VoteOption",
                columns: table => new
                {
                    OptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    NavigationUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    NodeId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VoteNum = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_VoteOption", x => x.OptionId);
                });

            migrationBuilder.CreateTable(
                name: "wcm_GovInteractChannel",
                columns: table => new
                {
                    NodeId = table.Column<int>(type: "int", nullable: false),
                    ApplyStyleId = table.Column<int>(type: "int", nullable: true),
                    DepartmentIdCollection = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    QueryStyleId = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcm_GovInteractChannel", x => x.NodeId);
                });

            migrationBuilder.CreateTable(
                name: "wcm_GovPublicApply",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CivicAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CivicCardNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CivicCardType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CivicEmail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CivicFax = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CivicName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CivicOrganization = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CivicPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CivicPostCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    DepartmentName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsApplyFree = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsOrganization = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    ObtainType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OrgAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OrgEmail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OrgFax = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OrgLegalPerson = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OrgLinkName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OrgName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OrgPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OrgPostCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OrgUnitCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ProvideType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QueryCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    State = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StyleId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcm_GovPublicApply", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wcm_GovPublicCategoryClass",
                columns: table => new
                {
                    ClassCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContentAttributeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsEnabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsSystem = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcm_GovPublicCategoryClass", x => new { x.ClassCode, x.PublishmentSystemId });
                });

            migrationBuilder.CreateTable(
                name: "wcm_GovPublicChannel",
                columns: table => new
                {
                    NodeId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcm_GovPublicChannel", x => x.NodeId);
                });

            migrationBuilder.CreateTable(
                name: "wcm_GovPublicIdentifierRule",
                columns: table => new
                {
                    RuleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttributeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FormatString = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdentifierType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MinLength = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    RuleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    SettingsXml = table.Column<string>(type: "ntext", nullable: true),
                    Suffix = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcm_GovPublicIdentifierRule", x => x.RuleId);
                });

            migrationBuilder.CreateTable(
                name: "wcm_GovPublicIdentifierSeq",
                columns: table => new
                {
                    SeqId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddYear = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    NodeId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Sequence = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcm_GovPublicIdentifierSeq", x => x.SeqId);
                });

            migrationBuilder.CreateTable(
                name: "wx_Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AppId = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AppSecret = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DefaultReplyKeyword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsBinding = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsDefaultReply = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsWelcome = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    SourceId = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ThumbUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Token = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    WeChatId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WelcomeKeyword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_Album",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PvCount = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Album", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_AlbumContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlbumId = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    LargeImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_AlbumContent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_Appointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ContentImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ContentIsSingle = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    ContentResultTopImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EndSummary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EndTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FormEmailTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FormMobileTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FormRealNameTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsFormEmail = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsFormMobile = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsFormRealName = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PvCount = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Appointment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_AppointmentContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AppointmentId = table.Column<int>(type: "int", nullable: true),
                    AppointmentItemId = table.Column<int>(type: "int", nullable: true),
                    CookieSn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Message = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    RealName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SettingsXml = table.Column<string>(type: "ntext", nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WxOpenId = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_AppointmentContent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_AppointmentItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppointmentId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescriptionTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ImageUrlCollection = table.Column<string>(type: "ntext", nullable: true),
                    ImageUrlCollectionTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImageUrlTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsDescription = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsImageUrl = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsImageUrlCollection = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsMap = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsTel = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsVideoUrl = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    LargeImageUrlCollection = table.Column<string>(type: "ntext", nullable: true),
                    MapAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MapTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Tel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TelTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TopImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UserCount = table.Column<int>(type: "int", nullable: true),
                    VideoUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    VideoUrlTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_AppointmentItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_Card",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CardNoColor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CardTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CardTitleColor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContentBackImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ContentFrontImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PvCount = table.Column<int>(type: "int", nullable: true),
                    ShopAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ShopName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ShopOperatorList = table.Column<string>(type: "ntext", nullable: true),
                    ShopPassword = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShopPosition = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ShopTel = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Card", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_CardCashLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CardId = table.Column<int>(type: "int", nullable: true),
                    CardSnId = table.Column<int>(type: "int", nullable: true),
                    CashType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ConsumeType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Operator = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_CardCashLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_CardEntitySn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CardId = table.Column<int>(type: "int", nullable: true),
                    Credits = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsBinding = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Sn = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_CardEntitySn", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_CardSignLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    SignDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_CardSignLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_CardSn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    CardId = table.Column<int>(type: "int", nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Sn = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_CardSn", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_Collect",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentDescription = table.Column<string>(type: "ntext", nullable: true),
                    ContentImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ContentIsCheck = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    ContentMaxVote = table.Column<int>(type: "int", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EndSummary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EndTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PvCount = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Collect", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_CollectItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CollectId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsChecked = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    LargeUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    SmallUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VoteNum = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_CollectItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_CollectLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CollectId = table.Column<int>(type: "int", nullable: true),
                    CookieSn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IpAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WxOpenId = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_CollectLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_Conference",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AgendaList = table.Column<string>(type: "ntext", nullable: true),
                    AgendaTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BackgroundImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ConferenceName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EndSummary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EndTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GuestList = table.Column<string>(type: "ntext", nullable: true),
                    GuestTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Introduction = table.Column<string>(type: "ntext", nullable: true),
                    IsAgenda = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsGuest = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PvCount = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Conference", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_ConferenceContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ConferenceId = table.Column<int>(type: "int", nullable: true),
                    CookieSn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IpAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Note = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Position = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    RealName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WxOpenId = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_ConferenceContent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_ConfigExtend",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttributeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FunctionId = table.Column<int>(type: "int", nullable: true),
                    IsVisible = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_ConfigExtend", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_Count",
                columns: table => new
                {
                    CountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Count = table.Column<int>(type: "int", nullable: true),
                    CountDay = table.Column<int>(type: "int", nullable: true),
                    CountMonth = table.Column<int>(type: "int", nullable: true),
                    CountType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CountYear = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Count", x => x.CountId);
                });

            migrationBuilder.CreateTable(
                name: "wx_Coupon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActId = table.Column<int>(type: "int", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TotalNum = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Coupon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_CouponAct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AwardCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContentDescription = table.Column<string>(type: "ntext", nullable: true),
                    ContentImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ContentUsage = table.Column<string>(type: "ntext", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EndSummary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EndTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FormAddressTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FormEmailTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FormMobileTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FormRealNameTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsFormAddress = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsFormEmail = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsFormMobile = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsFormRealName = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PvCount = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_CouponAct", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_CouponSn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CashDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CashUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CookieSn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CouponId = table.Column<int>(type: "int", nullable: true),
                    HoldAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    HoldDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HoldEmail = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    HoldMobile = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    HoldRealName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Sn = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WxOpenId = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_CouponSn", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_Keyword",
                columns: table => new
                {
                    KeywordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Keywords = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MatchType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Reply = table.Column<string>(type: "ntext", nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Keyword", x => x.KeywordId);
                });

            migrationBuilder.CreateTable(
                name: "wx_KeywordGroup",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_KeywordGroup", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "wx_KeywordMatch",
                columns: table => new
                {
                    MatchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    KeywordType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MatchType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_KeywordMatch", x => x.MatchId);
                });

            migrationBuilder.CreateTable(
                name: "wx_KeywordResource",
                columns: table => new
                {
                    ResourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChannelId = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsShowCoverPic = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    NavigationUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    ResourceType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_KeywordResource", x => x.ResourceId);
                });

            migrationBuilder.CreateTable(
                name: "wx_Lottery",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AwardCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AwardImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AwardMaxCount = table.Column<int>(type: "int", nullable: true),
                    AwardMaxDailyCount = table.Column<int>(type: "int", nullable: true),
                    AwardUsage = table.Column<string>(type: "ntext", nullable: true),
                    ContentAwardImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ContentImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ContentUsage = table.Column<string>(type: "ntext", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EndSummary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EndTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FormAddressTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FormEmailTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FormMobileTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FormRealNameTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsAwardTotalNum = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsFormAddress = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsFormEmail = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsFormMobile = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsFormRealName = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    LotteryType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PvCount = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Lottery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_LotteryAward",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AwardName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LotteryId = table.Column<int>(type: "int", nullable: true),
                    Probability = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TotalNum = table.Column<int>(type: "int", nullable: true),
                    WonNum = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_LotteryAward", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_LotteryLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CookieSn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastLotteryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LotteryCount = table.Column<int>(type: "int", nullable: true),
                    LotteryDailyCount = table.Column<int>(type: "int", nullable: true),
                    LotteryId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WxOpenId = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_LotteryLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_LotteryWinner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AwardId = table.Column<int>(type: "int", nullable: true),
                    CashDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CashSn = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CookieSn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    LotteryId = table.Column<int>(type: "int", nullable: true),
                    LotteryType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    RealName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WxOpenId = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_LotteryWinner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_Map",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    MapWd = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PvCount = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Map", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_Menu",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChannelId = table.Column<int>(type: "int", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MenuName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MenuType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true),
                    Url = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Menu", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "wx_Message",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentDescription = table.Column<string>(type: "ntext", nullable: true),
                    ContentImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PvCount = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Message", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_MessageContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Color = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Content = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CookieSn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IpAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsReply = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    LikeCookieSnCollection = table.Column<string>(type: "ntext", nullable: true),
                    LikeCount = table.Column<int>(type: "int", nullable: true),
                    MessageId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    ReplyCount = table.Column<int>(type: "int", nullable: true),
                    ReplyId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WxOpenId = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_MessageContent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_Search",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ImageAreaChannelId = table.Column<int>(type: "int", nullable: true),
                    ImageAreaTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsNavigation = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsOutsiteSearch = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    NavImageColor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NavTitleColor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PvCount = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TextAreaChannelId = table.Column<int>(type: "int", nullable: true),
                    TextAreaTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Search", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_SearchNavigation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChannelId = table.Column<int>(type: "int", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    FunctionId = table.Column<int>(type: "int", nullable: true),
                    ImageCssClass = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    KeywordType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NavigationType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    SearchId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Url = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_SearchNavigation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_Store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PvCount = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Store", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_StoreCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChildCount = table.Column<int>(type: "int", nullable: true),
                    IsLastNode = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    ParentsCount = table.Column<int>(type: "int", nullable: true),
                    ParentsPath = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    StoreCount = table.Column<int>(type: "int", nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_StoreCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_StoreItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Latitude = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Longitude = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: true),
                    StoreName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Summary = table.Column<string>(type: "ntext", nullable: true),
                    Tel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_StoreItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_View360",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentImageUrl1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ContentImageUrl2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ContentImageUrl3 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ContentImageUrl4 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ContentImageUrl5 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ContentImageUrl6 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PvCount = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_View360", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_Vote",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentDescription = table.Column<string>(type: "ntext", nullable: true),
                    ContentImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ContentIsCheckBox = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    ContentIsImageOption = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    ContentResultVisible = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    EndSummary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EndTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PvCount = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Vote", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_VoteItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    NavigationUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VoteId = table.Column<int>(type: "int", nullable: true),
                    VoteNum = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_VoteItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_VoteLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CookieSn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IpAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ItemIdCollection = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VoteId = table.Column<int>(type: "int", nullable: true),
                    WxOpenId = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_VoteLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_WebMenu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChannelId = table.Column<int>(type: "int", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    FunctionId = table.Column<int>(type: "int", nullable: true),
                    IconCssClass = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IconUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    KeywordType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MenuName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NavigationType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true),
                    Url = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_WebMenu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_Wifi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CallBackString = table.Column<string>(type: "ntext", nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    KeywordId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PvCount = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_Wifi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wx_WifiNode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CallBackString = table.Column<string>(type: "ntext", nullable: true),
                    NodeId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wx_WifiNode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bairong_TableMetadata",
                columns: table => new
                {
                    TableMetadataId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttributeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AuxiliaryTableEnName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DataLength = table.Column<int>(type: "int", nullable: true),
                    DataType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsSystem = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true),
                    bairong_TableCollectionTableEnName1 = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_TableMetadata", x => x.TableMetadataId);
                    table.ForeignKey(
                        name: "FK_bairong_TableMetadata_bairong_TableCollection_AuxiliaryTableEnName",
                        column: x => x.AuxiliaryTableEnName,
                        principalTable: "bairong_TableCollection",
                        principalColumn: "TableEnName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bairong_TableMetadata_bairong_TableCollection_bairong_TableCollectionTableEnName1",
                        column: x => x.bairong_TableCollectionTableEnName1,
                        principalTable: "bairong_TableCollection",
                        principalColumn: "TableEnName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "bairong_TableStyleItem",
                columns: table => new
                {
                    TableStyleItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsSelected = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    ItemTitle = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    ItemValue = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    TableStyleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_TableStyleItem", x => x.TableStyleItemId);
                    table.ForeignKey(
                        name: "FK_bairong_TableStyleItem_bairong_TableStyle_TableStyleId",
                        column: x => x.TableStyleId,
                        principalTable: "bairong_TableStyle",
                        principalColumn: "TableStyleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_Adv",
                columns: table => new
                {
                    AdvId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdAreaId = table.Column<int>(type: "int", nullable: false),
                    AdvName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FileTemplateIdCollection = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    IsDateLimited = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsEnabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    IsWeight = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    Level = table.Column<int>(type: "int", nullable: true),
                    LevelType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NodeIdCollectionToChannel = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    NodeIdCollectionToContent = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    RotateInterval = table.Column<int>(type: "int", nullable: true),
                    RotateType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_Adv", x => x.AdvId);
                    table.ForeignKey(
                        name: "FK_siteserver_Adv_siteserver_AdArea_AdAreaId",
                        column: x => x.AdAreaId,
                        principalTable: "siteserver_AdArea",
                        principalColumn: "AdAreaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_InputContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InputId = table.Column<int>(type: "int", nullable: false),
                    IpAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsChecked = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    Reply = table.Column<string>(type: "ntext", nullable: true),
                    SettingsXml = table.Column<string>(type: "ntext", nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_InputContent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_siteserver_InputContent_siteserver_Input_InputId",
                        column: x => x.InputId,
                        principalTable: "siteserver_Input",
                        principalColumn: "InputId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_RelatedFieldItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ItemValue = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    RelatedFieldId = table.Column<int>(type: "int", nullable: false),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_RelatedFieldItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_siteserver_RelatedFieldItem_siteserver_RelatedField_RelatedFieldId",
                        column: x => x.RelatedFieldId,
                        principalTable: "siteserver_RelatedField",
                        principalColumn: "RelatedFieldId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_TaskLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ErrorMessage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsSuccess = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    TaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_TaskLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_siteserver_TaskLog_siteserver_Task_TaskId",
                        column: x => x.TaskId,
                        principalTable: "siteserver_Task",
                        principalColumn: "TaskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "wcm_GovInteractLog",
                columns: table => new
                {
                    LogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    IpAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LogType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NodeId = table.Column<int>(type: "int", nullable: false),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcm_GovInteractLog", x => x.LogId);
                    table.ForeignKey(
                        name: "FK_wcm_GovInteractLog_wcm_GovInteractChannel_NodeId",
                        column: x => x.NodeId,
                        principalTable: "wcm_GovInteractChannel",
                        principalColumn: "NodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "wcm_GovInteractPermissions",
                columns: table => new
                {
                    NodeId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Permissions = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcm_GovInteractPermissions", x => new { x.NodeId, x.UserName });
                    table.ForeignKey(
                        name: "FK_wcm_GovInteractPermissions_wcm_GovInteractChannel_NodeId",
                        column: x => x.NodeId,
                        principalTable: "wcm_GovInteractChannel",
                        principalColumn: "NodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "wcm_GovInteractRemark",
                columns: table => new
                {
                    RemarkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    NodeId = table.Column<int>(type: "int", nullable: false),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RemarkType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcm_GovInteractRemark", x => x.RemarkId);
                    table.ForeignKey(
                        name: "FK_wcm_GovInteractRemark_wcm_GovInteractChannel_NodeId",
                        column: x => x.NodeId,
                        principalTable: "wcm_GovInteractChannel",
                        principalColumn: "NodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "wcm_GovInteractReply",
                columns: table => new
                {
                    ReplyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContentId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    FileUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NodeId = table.Column<int>(type: "int", nullable: false),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Reply = table.Column<string>(type: "ntext", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcm_GovInteractReply", x => x.ReplyId);
                    table.ForeignKey(
                        name: "FK_wcm_GovInteractReply_wcm_GovInteractChannel_NodeId",
                        column: x => x.NodeId,
                        principalTable: "wcm_GovInteractChannel",
                        principalColumn: "NodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "wcm_GovInteractType",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NodeId = table.Column<int>(type: "int", nullable: false),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcm_GovInteractType", x => x.TypeId);
                    table.ForeignKey(
                        name: "FK_wcm_GovInteractType_wcm_GovInteractChannel_NodeId",
                        column: x => x.NodeId,
                        principalTable: "wcm_GovInteractChannel",
                        principalColumn: "NodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "wcm_GovPublicApplyLog",
                columns: table => new
                {
                    LogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplyId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    IpAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LogType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    wcm_GovPublicApplyId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcm_GovPublicApplyLog", x => x.LogId);
                    table.ForeignKey(
                        name: "FK_wcm_GovPublicApplyLog_wcm_GovPublicApply_ApplyId",
                        column: x => x.ApplyId,
                        principalTable: "wcm_GovPublicApply",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wcm_GovPublicApplyLog_wcm_GovPublicApply_wcm_GovPublicApplyId1",
                        column: x => x.wcm_GovPublicApplyId1,
                        principalTable: "wcm_GovPublicApply",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "wcm_GovPublicApplyRemark",
                columns: table => new
                {
                    RemarkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplyId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RemarkType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    wcm_GovPublicApplyId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcm_GovPublicApplyRemark", x => x.RemarkId);
                    table.ForeignKey(
                        name: "FK_wcm_GovPublicApplyRemark_wcm_GovPublicApply_ApplyId",
                        column: x => x.ApplyId,
                        principalTable: "wcm_GovPublicApply",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wcm_GovPublicApplyRemark_wcm_GovPublicApply_wcm_GovPublicApplyId1",
                        column: x => x.wcm_GovPublicApplyId1,
                        principalTable: "wcm_GovPublicApply",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "wcm_GovPublicApplyReply",
                columns: table => new
                {
                    ReplyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplyId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    FileUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Reply = table.Column<string>(type: "ntext", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    wcm_GovPublicApplyId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcm_GovPublicApplyReply", x => x.ReplyId);
                    table.ForeignKey(
                        name: "FK_wcm_GovPublicApplyReply_wcm_GovPublicApply_ApplyId",
                        column: x => x.ApplyId,
                        principalTable: "wcm_GovPublicApply",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_wcm_GovPublicApplyReply_wcm_GovPublicApply_wcm_GovPublicApplyId1",
                        column: x => x.wcm_GovPublicApplyId1,
                        principalTable: "wcm_GovPublicApply",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "wcm_GovPublicCategory",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ChildrenCount = table.Column<int>(type: "int", nullable: true),
                    ClassCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContentNum = table.Column<int>(type: "int", nullable: true),
                    IsLastNode = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    ParentsCount = table.Column<int>(type: "int", nullable: true),
                    ParentsPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Taxis = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wcm_GovPublicCategory", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_wcm_GovPublicCategory_wcm_GovPublicCategoryClass_ClassCode_PublishmentSystemId",
                        columns: x => new { x.ClassCode, x.PublishmentSystemId },
                        principalTable: "wcm_GovPublicCategoryClass",
                        principalColumns: new[] { "ClassCode", "PublishmentSystemId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "siteserver_AdMaterial",
                columns: table => new
                {
                    AdMaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdMaterialName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdMaterialType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AdvId = table.Column<int>(type: "int", nullable: false),
                    AdvertId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "ntext", nullable: true),
                    ImageAlt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImageHeight = table.Column<int>(type: "int", nullable: true),
                    ImageLink = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ImageWidth = table.Column<int>(type: "int", nullable: true),
                    IsEnabled = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    TextColor = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    TextFontSize = table.Column<int>(type: "int", nullable: true),
                    TextLink = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TextWord = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteserver_AdMaterial", x => x.AdMaterialId);
                    table.ForeignKey(
                        name: "FK_siteserver_AdMaterial_siteserver_Adv_AdvId",
                        column: x => x.AdvId,
                        principalTable: "siteserver_Adv",
                        principalColumn: "AdvId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bairong_Roles",
                columns: table => new
                {
                    RoleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatorUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_Roles", x => x.RoleName);
                });

            migrationBuilder.CreateTable(
                name: "bairong_Administrator",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: true),
                    CountOfFailedLogin = table.Column<int>(type: "int", nullable: true),
                    CountOfLogin = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatorUserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsLockedOut = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: true),
                    LastActivityDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Mobile = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PasswordFormat = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    PublishmentSystemId = table.Column<int>(type: "int", nullable: true),
                    PublishmentSystemIdCollection = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    bairong_RolesRoleName = table.Column<string>(type: "nvarchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bairong_Administrator", x => x.UserName);
                    table.ForeignKey(
                        name: "FK_bairong_Administrator_bairong_Roles_bairong_RolesRoleName",
                        column: x => x.bairong_RolesRoleName,
                        principalTable: "bairong_Roles",
                        principalColumn: "RoleName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bairong_Administrator_bairong_RolesRoleName",
                table: "bairong_Administrator",
                column: "bairong_RolesRoleName");

            migrationBuilder.CreateIndex(
                name: "IX_bairong_TableMetadata_AuxiliaryTableEnName",
                table: "bairong_TableMetadata",
                column: "AuxiliaryTableEnName");

            migrationBuilder.CreateIndex(
                name: "IX_bairong_TableMetadata_bairong_TableCollectionTableEnName1",
                table: "bairong_TableMetadata",
                column: "bairong_TableCollectionTableEnName1");

            migrationBuilder.CreateIndex(
                name: "IX_bairong_TableStyleItem_TableStyleId",
                table: "bairong_TableStyleItem",
                column: "TableStyleId");

            migrationBuilder.CreateIndex(
                name: "IX_siteserver_AdMaterial_AdvId",
                table: "siteserver_AdMaterial",
                column: "AdvId");

            migrationBuilder.CreateIndex(
                name: "IX_siteserver_Adv_AdAreaId",
                table: "siteserver_Adv",
                column: "AdAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_siteserver_InputContent_InputId",
                table: "siteserver_InputContent",
                column: "InputId");

            migrationBuilder.CreateIndex(
                name: "IX_siteserver_RelatedFieldItem_RelatedFieldId",
                table: "siteserver_RelatedFieldItem",
                column: "RelatedFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_siteserver_TaskLog_TaskId",
                table: "siteserver_TaskLog",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_wcm_GovInteractLog_NodeId",
                table: "wcm_GovInteractLog",
                column: "NodeId");

            migrationBuilder.CreateIndex(
                name: "IX_wcm_GovInteractRemark_NodeId",
                table: "wcm_GovInteractRemark",
                column: "NodeId");

            migrationBuilder.CreateIndex(
                name: "IX_wcm_GovInteractReply_NodeId",
                table: "wcm_GovInteractReply",
                column: "NodeId");

            migrationBuilder.CreateIndex(
                name: "IX_wcm_GovInteractType_NodeId",
                table: "wcm_GovInteractType",
                column: "NodeId");

            migrationBuilder.CreateIndex(
                name: "IX_wcm_GovPublicApplyLog_ApplyId",
                table: "wcm_GovPublicApplyLog",
                column: "ApplyId");

            migrationBuilder.CreateIndex(
                name: "IX_wcm_GovPublicApplyLog_wcm_GovPublicApplyId1",
                table: "wcm_GovPublicApplyLog",
                column: "wcm_GovPublicApplyId1");

            migrationBuilder.CreateIndex(
                name: "IX_wcm_GovPublicApplyRemark_ApplyId",
                table: "wcm_GovPublicApplyRemark",
                column: "ApplyId");

            migrationBuilder.CreateIndex(
                name: "IX_wcm_GovPublicApplyRemark_wcm_GovPublicApplyId1",
                table: "wcm_GovPublicApplyRemark",
                column: "wcm_GovPublicApplyId1");

            migrationBuilder.CreateIndex(
                name: "IX_wcm_GovPublicApplyReply_ApplyId",
                table: "wcm_GovPublicApplyReply",
                column: "ApplyId");

            migrationBuilder.CreateIndex(
                name: "IX_wcm_GovPublicApplyReply_wcm_GovPublicApplyId1",
                table: "wcm_GovPublicApplyReply",
                column: "wcm_GovPublicApplyId1");

            migrationBuilder.CreateIndex(
                name: "IX_wcm_GovPublicCategory_ClassCode_PublishmentSystemId",
                table: "wcm_GovPublicCategory",
                columns: new[] { "ClassCode", "PublishmentSystemId" });

            migrationBuilder.AddForeignKey(
                name: "FK_bairong_Roles_bairong_Administrator_RoleName",
                table: "bairong_Roles",
                column: "RoleName",
                principalTable: "bairong_Administrator",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bairong_Administrator_bairong_Roles_bairong_RolesRoleName",
                table: "bairong_Administrator");

            migrationBuilder.DropTable(
                name: "bairong_Area");

            migrationBuilder.DropTable(
                name: "bairong_ContentCheck");

            migrationBuilder.DropTable(
                name: "bairong_ContentModel");

            migrationBuilder.DropTable(
                name: "bairong_Count");

            migrationBuilder.DropTable(
                name: "bairong_DbCache");

            migrationBuilder.DropTable(
                name: "bairong_Department");

            migrationBuilder.DropTable(
                name: "bairong_Digg");

            migrationBuilder.DropTable(
                name: "bairong_ErrorLog");

            migrationBuilder.DropTable(
                name: "bairong_Log");

            migrationBuilder.DropTable(
                name: "bairong_PermissionsInRoles");

            migrationBuilder.DropTable(
                name: "bairong_TableMatch");

            migrationBuilder.DropTable(
                name: "bairong_TableMetadata");

            migrationBuilder.DropTable(
                name: "bairong_TableStyleItem");

            migrationBuilder.DropTable(
                name: "bairong_Tags");

            migrationBuilder.DropTable(
                name: "bairong_ThirdLogin");

            migrationBuilder.DropTable(
                name: "bairong_UserBinding");

            migrationBuilder.DropTable(
                name: "bairong_UserGroup");

            migrationBuilder.DropTable(
                name: "bairong_UserLog");

            migrationBuilder.DropTable(
                name: "bairong_Users");

            migrationBuilder.DropTable(
                name: "model_Content");

            migrationBuilder.DropTable(
                name: "model_Job");

            migrationBuilder.DropTable(
                name: "model_Vote");

            migrationBuilder.DropTable(
                name: "model_WCM_GovInteract");

            migrationBuilder.DropTable(
                name: "model_WCM_GovPublic");

            migrationBuilder.DropTable(
                name: "siteserver_AdMaterial");

            migrationBuilder.DropTable(
                name: "siteserver_Advertisement");

            migrationBuilder.DropTable(
                name: "siteserver_AdvImageClassify");

            migrationBuilder.DropTable(
                name: "siteserver_AdvImageContent");

            migrationBuilder.DropTable(
                name: "siteserver_Comment");

            migrationBuilder.DropTable(
                name: "siteserver_ContentGroup");

            migrationBuilder.DropTable(
                name: "siteserver_CreateTask");

            migrationBuilder.DropTable(
                name: "siteserver_CreateTaskLog");

            migrationBuilder.DropTable(
                name: "siteserver_GatherDatabaseRule");

            migrationBuilder.DropTable(
                name: "siteserver_GatherFileRule");

            migrationBuilder.DropTable(
                name: "siteserver_GatherRule");

            migrationBuilder.DropTable(
                name: "siteserver_InnerLink");

            migrationBuilder.DropTable(
                name: "siteserver_InputContent");

            migrationBuilder.DropTable(
                name: "siteserver_Keyword");

            migrationBuilder.DropTable(
                name: "siteserver_Log");

            migrationBuilder.DropTable(
                name: "siteserver_MenuDisplay");

            migrationBuilder.DropTable(
                name: "siteserver_Node");

            migrationBuilder.DropTable(
                name: "siteserver_NodeGroup");

            migrationBuilder.DropTable(
                name: "siteserver_Photo");

            migrationBuilder.DropTable(
                name: "siteserver_PluginConfig");

            migrationBuilder.DropTable(
                name: "siteserver_PublishmentSystem");

            migrationBuilder.DropTable(
                name: "siteserver_RelatedFieldItem");

            migrationBuilder.DropTable(
                name: "siteserver_ResumeContent");

            migrationBuilder.DropTable(
                name: "siteserver_SeoMeta");

            migrationBuilder.DropTable(
                name: "siteserver_SeoMetasInNodes");

            migrationBuilder.DropTable(
                name: "siteserver_SigninLog");

            migrationBuilder.DropTable(
                name: "siteserver_SigninSetting");

            migrationBuilder.DropTable(
                name: "siteserver_SigninUserContentId");

            migrationBuilder.DropTable(
                name: "siteserver_Star");

            migrationBuilder.DropTable(
                name: "siteserver_StarSetting");

            migrationBuilder.DropTable(
                name: "siteserver_StlTag");

            migrationBuilder.DropTable(
                name: "siteserver_SystemPermissions");

            migrationBuilder.DropTable(
                name: "siteserver_TagStyle");

            migrationBuilder.DropTable(
                name: "siteserver_TaskLog");

            migrationBuilder.DropTable(
                name: "siteserver_Template");

            migrationBuilder.DropTable(
                name: "siteserver_TemplateLog");

            migrationBuilder.DropTable(
                name: "siteserver_TemplateMatch");

            migrationBuilder.DropTable(
                name: "siteserver_Tracking");

            migrationBuilder.DropTable(
                name: "siteserver_VoteOperation");

            migrationBuilder.DropTable(
                name: "siteserver_VoteOption");

            migrationBuilder.DropTable(
                name: "wcm_GovInteractLog");

            migrationBuilder.DropTable(
                name: "wcm_GovInteractPermissions");

            migrationBuilder.DropTable(
                name: "wcm_GovInteractRemark");

            migrationBuilder.DropTable(
                name: "wcm_GovInteractReply");

            migrationBuilder.DropTable(
                name: "wcm_GovInteractType");

            migrationBuilder.DropTable(
                name: "wcm_GovPublicApplyLog");

            migrationBuilder.DropTable(
                name: "wcm_GovPublicApplyRemark");

            migrationBuilder.DropTable(
                name: "wcm_GovPublicApplyReply");

            migrationBuilder.DropTable(
                name: "wcm_GovPublicCategory");

            migrationBuilder.DropTable(
                name: "wcm_GovPublicChannel");

            migrationBuilder.DropTable(
                name: "wcm_GovPublicIdentifierRule");

            migrationBuilder.DropTable(
                name: "wcm_GovPublicIdentifierSeq");

            migrationBuilder.DropTable(
                name: "wx_Account");

            migrationBuilder.DropTable(
                name: "wx_Album");

            migrationBuilder.DropTable(
                name: "wx_AlbumContent");

            migrationBuilder.DropTable(
                name: "wx_Appointment");

            migrationBuilder.DropTable(
                name: "wx_AppointmentContent");

            migrationBuilder.DropTable(
                name: "wx_AppointmentItem");

            migrationBuilder.DropTable(
                name: "wx_Card");

            migrationBuilder.DropTable(
                name: "wx_CardCashLog");

            migrationBuilder.DropTable(
                name: "wx_CardEntitySn");

            migrationBuilder.DropTable(
                name: "wx_CardSignLog");

            migrationBuilder.DropTable(
                name: "wx_CardSn");

            migrationBuilder.DropTable(
                name: "wx_Collect");

            migrationBuilder.DropTable(
                name: "wx_CollectItem");

            migrationBuilder.DropTable(
                name: "wx_CollectLog");

            migrationBuilder.DropTable(
                name: "wx_Conference");

            migrationBuilder.DropTable(
                name: "wx_ConferenceContent");

            migrationBuilder.DropTable(
                name: "wx_ConfigExtend");

            migrationBuilder.DropTable(
                name: "wx_Count");

            migrationBuilder.DropTable(
                name: "wx_Coupon");

            migrationBuilder.DropTable(
                name: "wx_CouponAct");

            migrationBuilder.DropTable(
                name: "wx_CouponSn");

            migrationBuilder.DropTable(
                name: "wx_Keyword");

            migrationBuilder.DropTable(
                name: "wx_KeywordGroup");

            migrationBuilder.DropTable(
                name: "wx_KeywordMatch");

            migrationBuilder.DropTable(
                name: "wx_KeywordResource");

            migrationBuilder.DropTable(
                name: "wx_Lottery");

            migrationBuilder.DropTable(
                name: "wx_LotteryAward");

            migrationBuilder.DropTable(
                name: "wx_LotteryLog");

            migrationBuilder.DropTable(
                name: "wx_LotteryWinner");

            migrationBuilder.DropTable(
                name: "wx_Map");

            migrationBuilder.DropTable(
                name: "wx_Menu");

            migrationBuilder.DropTable(
                name: "wx_Message");

            migrationBuilder.DropTable(
                name: "wx_MessageContent");

            migrationBuilder.DropTable(
                name: "wx_Search");

            migrationBuilder.DropTable(
                name: "wx_SearchNavigation");

            migrationBuilder.DropTable(
                name: "wx_Store");

            migrationBuilder.DropTable(
                name: "wx_StoreCategory");

            migrationBuilder.DropTable(
                name: "wx_StoreItem");

            migrationBuilder.DropTable(
                name: "wx_View360");

            migrationBuilder.DropTable(
                name: "wx_Vote");

            migrationBuilder.DropTable(
                name: "wx_VoteItem");

            migrationBuilder.DropTable(
                name: "wx_VoteLog");

            migrationBuilder.DropTable(
                name: "wx_WebMenu");

            migrationBuilder.DropTable(
                name: "wx_Wifi");

            migrationBuilder.DropTable(
                name: "wx_WifiNode");

            migrationBuilder.DropTable(
                name: "bairong_TableCollection");

            migrationBuilder.DropTable(
                name: "bairong_TableStyle");

            migrationBuilder.DropTable(
                name: "siteserver_Adv");

            migrationBuilder.DropTable(
                name: "siteserver_Input");

            migrationBuilder.DropTable(
                name: "siteserver_RelatedField");

            migrationBuilder.DropTable(
                name: "siteserver_Task");

            migrationBuilder.DropTable(
                name: "wcm_GovInteractChannel");

            migrationBuilder.DropTable(
                name: "wcm_GovPublicApply");

            migrationBuilder.DropTable(
                name: "wcm_GovPublicCategoryClass");

            migrationBuilder.DropTable(
                name: "siteserver_AdArea");

            migrationBuilder.DropTable(
                name: "bairong_Roles");

            migrationBuilder.DropTable(
                name: "bairong_Administrator");
        }
    }
}
