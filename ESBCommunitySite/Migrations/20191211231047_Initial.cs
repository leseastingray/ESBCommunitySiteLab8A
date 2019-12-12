using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ESBCommunitySite.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Instrument = table.Column<string>(nullable: true),
                    DateJoined = table.Column<string>(nullable: true),
                    Board = table.Column<bool>(nullable: false),
                    SectionLeader = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberID);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageInfoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Recipient = table.Column<string>(nullable: false),
                    MessageText = table.Column<string>(nullable: false),
                    Sender = table.Column<string>(nullable: false),
                    MessageDate = table.Column<DateTime>(nullable: false),
                    MessagePriority = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageInfoID);
                });

            migrationBuilder.CreateTable(
                name: "PotentialMembers",
                columns: table => new
                {
                    PotentialMemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Instrument = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    RequestDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PotentialMembers", x => x.PotentialMemberID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "PotentialMembers");
        }
    }
}
