using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LMS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
