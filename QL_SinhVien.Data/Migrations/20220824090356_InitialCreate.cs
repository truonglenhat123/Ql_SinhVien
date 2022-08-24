using Microsoft.EntityFrameworkCore.Migrations;

namespace QL_SinhVien.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SinhVienDB",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mssv = table.Column<int>(nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Fullname = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVienDB", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhVienDB");
        }
    }
}
