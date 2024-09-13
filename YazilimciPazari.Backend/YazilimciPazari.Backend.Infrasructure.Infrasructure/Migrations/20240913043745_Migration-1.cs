using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YazilimciPazari.Backend.Infrasructure.Infrasructure.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Okusana");

            migrationBuilder.CreateTable(
                name: "Comments",
                schema: "Okusana",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Text = table.Column<string>(type: "text", unicode: false, maxLength: 500, nullable: false, comment: "Yorum yazılarının saklandığı yer")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                schema: "Okusana",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "text", maxLength: 10000, nullable: false),
                    TaxNumber = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                schema: "Okusana",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, comment: "Yorum yazılarının saklandığı yer")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Okusana",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "Okusana",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompanyComments",
                schema: "Okusana",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyComment_Comment",
                        column: x => x.CommentId,
                        principalSchema: "Okusana",
                        principalTable: "Comments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyComment_Company",
                        column: x => x.CompanyId,
                        principalSchema: "Okusana",
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompanySkills",
                schema: "Okusana",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanySkill_Company",
                        column: x => x.CompanyId,
                        principalSchema: "Okusana",
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanySkill_Skill",
                        column: x => x.SkillId,
                        principalSchema: "Okusana",
                        principalTable: "Skills",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                schema: "Okusana",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "text", maxLength: 1000, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_User",
                        column: x => x.UserId,
                        principalSchema: "Okusana",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserComments",
                schema: "Okusana",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserComment_Comment",
                        column: x => x.CommentId,
                        principalSchema: "Okusana",
                        principalTable: "Comments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserComment_User",
                        column: x => x.UserId,
                        principalSchema: "Okusana",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserSkills",
                schema: "Okusana",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSkill_Skill",
                        column: x => x.SkillId,
                        principalSchema: "Okusana",
                        principalTable: "Skills",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserSkill_User",
                        column: x => x.UserId,
                        principalSchema: "Okusana",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProjectSkills",
                schema: "Okusana",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SkillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectSkill_Project",
                        column: x => x.ProjectId,
                        principalSchema: "Okusana",
                        principalTable: "Projects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProjectSkill_Skill",
                        column: x => x.SkillId,
                        principalSchema: "Okusana",
                        principalTable: "Skills",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_IsDeleted",
                schema: "Okusana",
                table: "Comments",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_IsDeleted",
                schema: "Okusana",
                table: "Companies",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_TaxNumber_Password",
                schema: "Okusana",
                table: "Companies",
                columns: new[] { "TaxNumber", "Password" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyComments_CommentId_CompanyId",
                schema: "Okusana",
                table: "CompanyComments",
                columns: new[] { "CommentId", "CompanyId" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyComments_CompanyId",
                schema: "Okusana",
                table: "CompanyComments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyComments_IsDeleted",
                schema: "Okusana",
                table: "CompanyComments",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_CompanySkills_CompanyId",
                schema: "Okusana",
                table: "CompanySkills",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanySkills_IsDeleted",
                schema: "Okusana",
                table: "CompanySkills",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_CompanySkills_SkillId_CompanyId",
                schema: "Okusana",
                table: "CompanySkills",
                columns: new[] { "SkillId", "CompanyId" });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_IsDeleted",
                schema: "Okusana",
                table: "Projects",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                schema: "Okusana",
                table: "Projects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkills_IsDeleted",
                schema: "Okusana",
                table: "ProjectSkills",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkills_ProjectId_SkillId",
                schema: "Okusana",
                table: "ProjectSkills",
                columns: new[] { "ProjectId", "SkillId" });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkills_SkillId",
                schema: "Okusana",
                table: "ProjectSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_IsDeleted",
                schema: "Okusana",
                table: "Skills",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_UserComments_CommentId_UserId",
                schema: "Okusana",
                table: "UserComments",
                columns: new[] { "CommentId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserComments_IsDeleted",
                schema: "Okusana",
                table: "UserComments",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_UserComments_UserId",
                schema: "Okusana",
                table: "UserComments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_IsDeleted",
                schema: "Okusana",
                table: "Users",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserId",
                schema: "Okusana",
                table: "Users",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_IsDeleted",
                schema: "Okusana",
                table: "UserSkills",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_SkillId",
                schema: "Okusana",
                table: "UserSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_UserId_SkillId",
                schema: "Okusana",
                table: "UserSkills",
                columns: new[] { "UserId", "SkillId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyComments",
                schema: "Okusana");

            migrationBuilder.DropTable(
                name: "CompanySkills",
                schema: "Okusana");

            migrationBuilder.DropTable(
                name: "ProjectSkills",
                schema: "Okusana");

            migrationBuilder.DropTable(
                name: "UserComments",
                schema: "Okusana");

            migrationBuilder.DropTable(
                name: "UserSkills",
                schema: "Okusana");

            migrationBuilder.DropTable(
                name: "Companies",
                schema: "Okusana");

            migrationBuilder.DropTable(
                name: "Projects",
                schema: "Okusana");

            migrationBuilder.DropTable(
                name: "Comments",
                schema: "Okusana");

            migrationBuilder.DropTable(
                name: "Skills",
                schema: "Okusana");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "Okusana");
        }
    }
}
