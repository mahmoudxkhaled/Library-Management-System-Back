using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LMS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ActivationUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ActivationUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationYear = table.Column<int>(type: "int", nullable: false),
                    AvailableCopies = table.Column<int>(type: "int", nullable: false),
                    TotalCopies = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    InsertedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ActivationUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookId1 = table.Column<int>(type: "int", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ActivationUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedback_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedback_Book_BookId1",
                        column: x => x.BookId1,
                        principalTable: "Book",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookId1 = table.Column<int>(type: "int", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ActivationUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaction_Book_BookId1",
                        column: x => x.BookId1,
                        principalTable: "Book",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TrendingBooks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookId1 = table.Column<int>(type: "int", nullable: true),
                    BorrowCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrendingBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrendingBooks_Book_BookId1",
                        column: x => x.BookId1,
                        principalTable: "Book",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "ActivationTime", "ActivationUserId", "DeletedTime", "DeletedUserId", "Description", "ImageUrl", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "Name", "UpdateTime", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, null, null, null, null, "Books that contain stories created from the imagination.", null, null, null, true, false, "Fiction", null, null },
                    { 2, null, null, null, null, "Books based on real facts and events.", null, null, null, true, false, "Non-Fiction", null, null },
                    { 3, null, null, null, null, "Books related to scientific principles, experiments, and discoveries.", null, null, null, true, false, "Science", null, null },
                    { 4, null, null, null, null, "Books covering mathematical theories, problems, and equations.", null, null, null, true, false, "Mathematics", null, null },
                    { 5, null, null, null, null, "Books that discuss past events and historical occurrences.", null, null, null, true, false, "History", null, null },
                    { 6, null, null, null, null, "Books about the lives of individuals, either famous or historical.", null, null, null, true, false, "Biography", null, null },
                    { 7, null, null, null, null, "Books considered to have artistic value, including poetry, novels, and drama.", null, null, null, true, false, "Literature", null, null },
                    { 8, null, null, null, null, "Books that explore fundamental questions about existence, knowledge, and ethics.", null, null, null, true, false, "Philosophy", null, null },
                    { 9, null, null, null, null, "Books related to human behavior, emotions, and cognitive functions.", null, null, null, true, false, "Psychology", null, null },
                    { 10, null, null, null, null, "Books that provide advice or strategies for improving life and personal growth.", null, null, null, true, false, "Self-Help", null, null },
                    { 11, null, null, null, null, "Books that focus on various forms of art, including visual arts, sculpture, and performance.", null, null, null, true, false, "Art", null, null },
                    { 12, null, null, null, null, "Books that discuss musical theory, history, and performance techniques.", null, null, null, true, false, "Music", null, null },
                    { 13, null, null, null, null, "Books focused on physical well-being, exercise, and mental health.", null, null, null, true, false, "Health & Fitness", null, null },
                    { 14, null, null, null, null, "Books providing recipes and cooking techniques.", null, null, null, true, false, "Cooking", null, null },
                    { 15, null, null, null, null, "Books that explore destinations, cultures, and experiences in different parts of the world.", null, null, null, true, false, "Travel", null, null },
                    { 16, null, null, null, null, "Books intended for young readers, including stories and educational books.", null, null, null, true, false, "Children's Books", null, null },
                    { 17, null, null, null, null, "Books containing magical or fantastical elements set in imaginary worlds.", null, null, null, true, false, "Fantasy", null, null },
                    { 18, null, null, null, null, "Books set in the future or in space, often incorporating advanced technology or extraterrestrial life.", null, null, null, true, false, "Science Fiction", null, null },
                    { 19, null, null, null, null, "Books centered around solving a crime or uncovering secrets.", null, null, null, true, false, "Mystery", null, null },
                    { 20, null, null, null, null, "Books designed to keep the reader on edge with suspense and tension.", null, null, null, true, false, "Thriller", null, null },
                    { 21, null, null, null, null, "Books designed to evoke fear or unease in the reader.", null, null, null, true, false, "Horror", null, null },
                    { 22, null, null, null, null, "Books containing poems, written in verse.", null, null, null, true, false, "Poetry", null, null },
                    { 23, null, null, null, null, "Books focused on religious studies, scriptures, and beliefs.", null, null, null, true, false, "Religion", null, null },
                    { 24, null, null, null, null, "Books that explore personal growth and the search for meaning beyond the material world.", null, null, null, true, false, "Spirituality", null, null },
                    { 25, null, null, null, null, "Books that explore political theory, history, and analysis.", null, null, null, true, false, "Politics", null, null },
                    { 26, null, null, null, null, "Books about the production, distribution, and consumption of goods and services.", null, null, null, true, false, "Economics", null, null },
                    { 27, null, null, null, null, "Books on management, entrepreneurship, and business strategies.", null, null, null, true, false, "Business", null, null },
                    { 28, null, null, null, null, "Books covering advancements in technology, including programming, artificial intelligence, and gadgets.", null, null, null, true, false, "Technology", null, null },
                    { 29, null, null, null, null, "Books on engineering principles, innovations, and applications.", null, null, null, true, false, "Engineering", null, null },
                    { 30, null, null, null, null, "Books about legal studies, statutes, and legal principles.", null, null, null, true, false, "Law", null, null },
                    { 31, null, null, null, null, "Books about the art and techniques of photography.", null, null, null, true, false, "Photography", null, null },
                    { 32, null, null, null, null, "Books on the design and construction of buildings and other structures.", null, null, null, true, false, "Architecture", null, null },
                    { 33, null, null, null, null, "Books about various sports, athletes, and sporting events.", null, null, null, true, false, "Sports", null, null },
                    { 34, null, null, null, null, "Books focused on ecology, nature conservation, and environmental science.", null, null, null, true, false, "Environment", null, null },
                    { 35, null, null, null, null, "Books about cities, urban planning, and metropolitan life.", null, null, null, true, false, "Urban Studies", null, null },
                    { 36, null, null, null, null, "Books related to financial markets, investment strategies, and economic theory.", null, null, null, true, false, "Economics & Finance", null, null },
                    { 37, null, null, null, null, "Books offering advice for raising children and family dynamics.", null, null, null, true, false, "Parenting", null, null },
                    { 38, null, null, null, null, "Books on educational methods, theories, and teaching practices.", null, null, null, true, false, "Education", null, null },
                    { 39, null, null, null, null, "Books consisting of illustrated stories in a comic strip format.", null, null, null, true, false, "Comic Books", null, null },
                    { 40, null, null, null, null, "Books that combine illustrations with narrative storytelling, typically in a longer form.", null, null, null, true, false, "Graphic Novels", null, null },
                    { 41, null, null, null, null, "Books covering sociology, anthropology, and other social studies disciplines.", null, null, null, true, false, "Social Sciences", null, null },
                    { 42, null, null, null, null, "Books related to the scientific study of language and its structure.", null, null, null, true, false, "Linguistics", null, null },
                    { 43, null, null, null, null, "Books about physical geography, the study of places and environments.", null, null, null, true, false, "Geography", null, null },
                    { 44, null, null, null, null, "Books about space exploration, the universe, stars, and planets.", null, null, null, true, false, "Space & Astronomy", null, null },
                    { 45, null, null, null, null, "Books that incorporate mathematical themes or problems in their stories.", null, null, null, true, false, "Mathematical Fiction", null, null },
                    { 46, null, null, null, null, "Books about the history and collection of valuable items.", null, null, null, true, false, "Antiques & Collectibles", null, null },
                    { 47, null, null, null, null, "Books about various crafts, from knitting to woodworking.", null, null, null, true, false, "Crafts & Hobbies", null, null },
                    { 48, null, null, null, null, "Books about planting, cultivating, and maintaining gardens.", null, null, null, true, false, "Gardening", null, null },
                    { 49, null, null, null, null, "Books that focus on managing personal wealth, budgeting, and investing.", null, null, null, true, false, "Personal Finance", null, null },
                    { 50, null, null, null, null, "Books that explore real-life criminal cases and investigations.", null, null, null, true, false, "True Crime", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryId",
                table: "Book",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_BookId1",
                table: "Feedback",
                column: "BookId1");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_UserId",
                table: "Feedback",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_BookId1",
                table: "Transaction",
                column: "BookId1");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_UserId",
                table: "Transaction",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TrendingBooks_BookId1",
                table: "TrendingBooks",
                column: "BookId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "TrendingBooks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
