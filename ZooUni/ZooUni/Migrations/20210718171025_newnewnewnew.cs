using Microsoft.EntityFrameworkCore.Migrations;

namespace ZooUni.Migrations
{
    public partial class newnewnewnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kind = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Kind", "Name", "Type", "URL" },
                values: new object[,]
                {
                    { 1, "Predator", "Pombercho", "Tiger", "https://www.permaculturenews.org/wp-content/uploads/2020/10/Tiger-Supermarket.jpg" },
                    { 2, "Predator", "Mufasa", "Lion", "https://ewscripps.brightspotcdn.com/b8/97/543aa49f42adb4cf0e361b3f556d/t10-0078-002.jpg" },
                    { 3, "Mammal", "", "Giraffe", "https://www.gannett-cdn.com/presto/2019/06/21/PKNS/6d8c357f-2dd6-4730-8d85-5eb6a481ec2a-kns-zoo-0622_BP.JPG" },
                    { 4, "Predator", "", "Bear", "https://www.indianapoliszoo.com/wp-content/uploads/2018/04/CROPPED_Brown_Bear-Cheryl_Wesselresizedresized.jpg" },
                    { 5, "Mammal", "", "Elephant", "https://media.npr.org/assets/img/2017/01/10/elephant1_custom-14cf2c849d4a2c5aaac9d1b017f64c4adb9f04e4.jpg" },
                    { 6, "Reptile", "", "Crocodile", "https://bristolzoo.org.uk/cmsassets/body/Animals-and-Attractions/Dwarf-Crocodiles/_galleryMainNew/Dwarf-Crododiles-gallery-1.jpg" },
                    { 7, "Predator", "", "Wolf", "https://arc-anglerfish-arc2-prod-tronc.s3.amazonaws.com/public/UXEKVA33VJB6VL4ZEYDXF4NTOY.JPG" },
                    { 8, "Mammal", "", "Deer", "https://cdn.pixabay.com/photo/2017/05/23/10/22/deer-2336769_960_720.jpg" },
                    { 9, "Mammal", "", "Gorilla", "http://cincinnatizoo.org/wp-content/uploads/2014/04/gladys_jomo-005.jpg" },
                    { 10, "Predator", "", "Hippopotamus", "https://s.hdnux.com/photos/70/22/51/14756432/3/rawImage.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
