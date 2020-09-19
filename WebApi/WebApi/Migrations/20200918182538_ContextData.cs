using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class ContextData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "variables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VId = table.Column<string>(nullable: true),
                    Rowid = table.Column<int>(nullable: false),
                    Avalue = table.Column<string>(nullable: true),
                    AddressOut = table.Column<int>(nullable: false),
                    AddressIn = table.Column<int>(nullable: false),
                    Bvalue = table.Column<string>(nullable: true),
                    Bit_position = table.Column<string>(nullable: true),
                    Buttonpath = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Defaultvalue = table.Column<int>(nullable: false),
                    Delay = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Dimension = table.Column<int>(nullable: false),
                    Frequency = table.Column<int>(nullable: false),
                    Functioncode = table.Column<string>(nullable: true),
                    Grpcategory = table.Column<int>(nullable: false),
                    Idgroup = table.Column<int>(nullable: false),
                    Idhsvariable = table.Column<int>(nullable: false),
                    Idvarmdl = table.Column<string>(nullable: true),
                    Idvariable = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_variables", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "variables");
        }
    }
}
