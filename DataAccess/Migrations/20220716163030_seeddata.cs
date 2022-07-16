using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Color", "Description", "Name", "Quantity", "Weight" },
                values: new object[,]
                {
                    { 1, "Philips", "White", "Mauris nullam consectetuer placerat vulputate eu metus suspendisse natoque cras dis accumsan primis donec fusce si nascetur nisi litora odio", "Lamp", 100, 11.5 },
                    { 2, "Sedona", "Black", "In velit per rutrum adipiscing nisi ante facilisi cursus montes accumsan suspendisse pulvinar leo tellus mollis metus fusce quis faucibus", "Bicycle", 90, 23.800000000000001 },
                    { 3, "Bellona", "Green", "Pulvinar tincidunt potenti velit taciti aptent augue conubia gravida odio volutpat rhoncus ipsum inceptos facilisis adipiscing primis dis elit ullamcorper", "Table", 80, 35.899999999999999 },
                    { 4, "Asus", "Blue", "Lorem maximus condimentum est nunc urna purus sem arcu in sit mauris fusce tincidunt tristique maecenas iaculis nec mollis ad", "Monitor", 70, 42.399999999999999 },
                    { 5, "Bellona", "Red", "Ipsum tristique nunc condimentum fusce ante consectetur litora platea ultricies congue etiam eros vivamus pharetra venenatis fringilla maximus integer conubia", "Wardrobe", 60, 56.799999999999997 },
                    { 6, "Fakir", "Orange", "Proin scelerisque phasellus augue netus nascetur ante purus lorem neque mauris commodo nam quisque finibus vivamus imperdiet nec himenaeos cursus", "Vacuum Cleaner", 50, 68.400000000000006 },
                    { 7, "Arçelik", "White", "Eros mauris primis lobortis tellus netus potenti sapien consectetur dui eu magnis dictum gravida parturient est massa non felis sagittis", "Fridge", 40, 74.799999999999997 },
                    { 8, "LG", "Black", "Feugiat curae quisque pede accumsan sed dis sodales ante convallis parturient cursus lectus platea duis maecenas non netus fermentum maximus", "Television", 30, 89.5 },
                    { 9, "Bellona", "Brown", "Quam leo platea vehicula posuere iaculis adipiscing morbi cursus sollicitudin feugiat dapibus dolor eu tellus tortor accumsan nec tempor hendrerit", "Bed", 20, 91.5 },
                    { 10, "Arçelik", "White", "Scelerisque pulvinar dapibus aptent sodales habitant erat dictum luctus mollis faucibus porttitor augue diam magna hendrerit volutpat quam venenatis velit", "Washing Machine", 10, 100.09999999999999 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Description", "ProductId" },
                values: new object[,]
                {
                    { 1, "Vestibulum convallis aptent massa mollis aliquam conubia enim purus rutrum orci facilisis aenean dignissim habitasse venenatis phasellus consectetur nascetur sapien", 1 },
                    { 2, "Fames aliquet si tellus lorem eleifend orci nisi netus massa parturient curae sit urna vitae congue risus eros id senectus", 2 },
                    { 3, "Quis justo mollis duis mattis sapien dis si quisque nunc metus class volutpat tempor lectus a nisl hendrerit etiam massa", 3 },
                    { 4, "Maximus aptent cras consequat tristique proin rhoncus urna maecenas a si bibendum egestas augue adipiscing vehicula mus iaculis ultricies quam", 4 },
                    { 5, "Bibendum feugiat viverra nullam interdum mauris venenatis eleifend condimentum augue eu tempor vitae finibus luctus tellus pede nibh egestas facilisis", 5 },
                    { 6, "Metus erat fermentum vivamus scelerisque mollis condimentum nunc tristique nisl nascetur hac egestas blandit phasellus suscipit auctor class consectetur consequat", 6 },
                    { 7, "Consectetuer nullam sollicitudin letius torquent finibus in tincidunt accumsan maximus volutpat ad adipiscing curabitur commodo ut eget nibh suspendisse lacus", 7 },
                    { 8, "Rutrum nullam dictumst habitasse facilisi sit placerat praesent libero felis mauris fringilla porttitor tempor vestibulum bibendum amet nam class est", 8 },
                    { 9, "Molestie odio dictumst rutrum condimentum imperdiet aliquet vel massa accumsan dictum per netus inceptos lacus justo ultricies purus lorem enim", 9 },
                    { 10, "Enim cubilia sodales ligula ornare luctus sapien ut neque dictum laoreet aptent malesuada porta faucibus fames posuere consectetuer pretium adipiscing", 10 }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "Path", "ProductId" },
                values: new object[,]
                {
                    { 1, "/Images/Lamp/1.jpg", 1 },
                    { 2, "/Images/Bicycle/1.jpg", 2 },
                    { 3, "/Images/Table/1.jpg", 3 },
                    { 4, "/Images/Monitor/1.jpg", 4 },
                    { 5, "/Images/Wardrobe/1.jpg", 5 },
                    { 6, "/Images/Vacuum Cleaner/1.jpg", 6 },
                    { 7, "/Images/Fridge/1.jpg", 7 },
                    { 8, "/Images/Television/1.jpg", 8 },
                    { 9, "/Images/Bed/1.jpg", 9 },
                    { 10, "/Images/Washing Machine/1.jpg", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ProductId",
                table: "Photos",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
