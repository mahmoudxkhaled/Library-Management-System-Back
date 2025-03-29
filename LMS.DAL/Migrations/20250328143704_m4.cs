using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LMS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DateOfBirth", "Description", "FullName", "ImageUrl" },
                values: new object[,]
                {
                    { 1, new DateOnly(1896, 9, 1), "American novelist, best known for 'The Great Gatsby.'", "F. Scott Fitzgerald", null },
                    { 2, new DateOnly(1926, 4, 20), "American author of 'To Kill a Mockingbird.'", "Harper Lee", null },
                    { 3, new DateOnly(1976, 2, 24), "Israeli historian and author of 'Sapiens.'", "Yuval Noah Harari", null },
                    { 4, new DateOnly(1986, 9, 27), "American memoirist, known for 'Educated.'", "Tara Westover", null },
                    { 5, new DateOnly(1942, 1, 8), "English theoretical physicist, known for 'A Brief History of Time.'", "Stephen Hawking", null },
                    { 6, new DateOnly(1941, 3, 26), "English evolutionary biologist, author of 'The Selfish Gene.'", "Richard Dawkins", null },
                    { 7, new DateOnly(1959, 5, 13), "American mathematician, author of 'The Joy of x.'", "Steven Strogatz", null },
                    { 8, new DateOnly(1838, 12, 20), "English schoolmaster and theologian, known for 'Flatland.'", "Edwin A. Abbott", null },
                    { 9, new DateOnly(1929, 6, 12), "Jewish diarist, known for 'The Diary of a Young Girl.'", "Anne Frank", null },
                    { 10, new DateOnly(1971, 8, 10), "British historian, author of 'The Silk Roads.'", "Peter Frankopan", null },
                    { 11, new DateOnly(1952, 5, 20), "American author and biographer, known for 'Steve Jobs.'", "Walter Isaacson", null },
                    { 12, new DateOnly(1925, 5, 19), "African American civil rights leader, co-author of 'The Autobiography of Malcolm X.'", "Malcolm X", null },
                    { 13, new DateOnly(1819, 8, 1), "American author, known for 'Moby-Dick.'", "Herman Melville", null },
                    { 14, new DateOnly(1775, 12, 16), "English novelist, best known for 'Pride and Prejudice.'", "Jane Austen", null },
                    { 15, new DateOnly(121, 4, 26), "Roman Emperor, known for 'Meditations.'", "Marcus Aurelius", null },
                    { 16, new DateOnly(427, 5, 21), "Ancient Greek philosopher, author of 'The Republic.'", "Plato", null },
                    { 17, new DateOnly(1934, 3, 5), "Israeli-American psychologist, author of 'Thinking, Fast and Slow.'", "Daniel Kahneman", null },
                    { 18, new DateOnly(1974, 4, 27), "American journalist, author of 'The Power of Habit.'", "Charles Duhigg", null },
                    { 19, new DateOnly(1986, 7, 22), "Author of 'Atomic Habits.'", "James Clear", null },
                    { 20, new DateOnly(1932, 10, 24), "American educator, author of 'The 7 Habits of Highly Effective People.'", "Stephen R. Covey", null },
                    { 21, new DateOnly(1909, 3, 20), "Austrian-born British art historian, known for 'The Story of Art.'", "E.H. Gombrich", null },
                    { 22, new DateOnly(1926, 11, 5), "British art critic and theorist, author of 'Ways of Seeing.'", "John Berger", null },
                    { 23, new DateOnly(1968, 11, 10), "American music critic, author of 'The Rest Is Noise.'", "Alex Ross", null },
                    { 24, new DateOnly(1952, 5, 14), "American musician and author of 'How Music Works.'", "David Byrne", null },
                    { 25, new DateOnly(1943, 7, 5), "Dutch-American psychiatrist, author of 'The Body Keeps the Score.'", "Bessel van der Kolk", null },
                    { 26, new DateOnly(1962, 6, 10), "American author, known for 'Born to Run.'", "Christopher McDougall", null },
                    { 27, new DateOnly(1877, 3, 15), "American author, known for 'The Joy of Cooking.'", "Irma S. Rombauer", null },
                    { 28, new DateOnly(1979, 11, 7), "American chef and author of 'Salt, Fat, Acid, Heat.'", "Samin Nosrat", null },
                    { 29, new DateOnly(1954, 4, 12), "American author, known for 'Into the Wild.'", "Jon Krakauer", null },
                    { 30, new DateOnly(1962, 10, 26), "American author, known for 'The Geography of Bliss.'", "Eric Weiner", null },
                    { 31, new DateOnly(1965, 7, 20), "British author, known for the 'Harry Potter' series.", "J.K. Rowling", null },
                    { 32, new DateOnly(1928, 6, 10), "American author of children's books, known for 'Where the Wild Things Are.'", "Maurice Sendak", null },
                    { 33, new DateOnly(1892, 1, 3), "English author, known for 'The Hobbit.'", "J.R.R. Tolkien", null },
                    { 34, new DateOnly(1973, 6, 6), "American author, known for 'The Name of the Wind.'", "Patrick Rothfuss", null },
                    { 35, new DateOnly(1920, 10, 8), "American science fiction author, known for 'Dune.'", "Frank Herbert", null },
                    { 36, new DateOnly(1948, 3, 17), "American-Canadian author, known for 'Neuromancer.'", "William Gibson", null },
                    { 37, new DateOnly(1954, 8, 15), "Swedish author, known for 'The Girl with the Dragon Tattoo.'", "Stieg Larsson", null },
                    { 38, new DateOnly(1971, 2, 24), "American author, known for 'Gone Girl.'", "Gillian Flynn", null },
                    { 39, new DateOnly(1968, 11, 22), "Cypriot-British author, known for 'The Silent Patient.'", "Alex Michaelides", null },
                    { 40, new DateOnly(1972, 8, 26), "British author, known for 'The Girl on the Train.'", "Paula Hawkins", null },
                    { 41, new DateOnly(1920, 8, 22), "American author, known for 'Fahrenheit 451.'", "Ray Bradbury", null },
                    { 42, new DateOnly(1903, 6, 25), "British author, known for '1984.'", "George Orwell", null },
                    { 43, new DateOnly(1894, 7, 26), "English author, known for 'Brave New World.'", "Aldous Huxley", null },
                    { 44, new DateOnly(1939, 11, 18), "Canadian author, known for 'The Handmaid's Tale.'", "Margaret Atwood", null },
                    { 45, new DateOnly(1919, 1, 1), "American author, known for 'The Catcher in the Rye.'", "J.D. Salinger", null },
                    { 46, new DateOnly(1950, 7, 22), "American author, known for 'The Outsiders.'", "S.E. Hinton", null },
                    { 47, new DateOnly(1854, 10, 16), "Irish author, known for 'The Picture of Dorian Gray.'", "Oscar Wilde", null },
                    { 48, new DateOnly(1797, 8, 20), "English author, known for 'Frankenstein.'", "Mary Shelley", null },
                    { 49, new DateOnly(1847, 11, 8), "Irish author, known for 'Dracula.'", "Bram Stoker", null },
                    { 50, new DateOnly(1821, 11, 11), "Russian author, known for 'Crime and Punishment.'", "Fyodor Dostoevsky", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
