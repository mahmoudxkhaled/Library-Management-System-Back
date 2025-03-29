using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LMS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "ActivationTime", "ActivationUserId", "AuthorId", "AvailableCopies", "CategoryId", "DeletedTime", "DeletedUserId", "Description", "ImageUrl", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "PublicationYear", "Title", "TotalCopies", "UpdateTime", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, null, null, 1, 10, 1, null, null, "A novel about the American dream and the Jazz Age.", null, null, null, true, false, 1925, "The Great Gatsby", 15, null, null },
                    { 2, null, null, 2, 8, 1, null, null, "A novel about racial injustice in the Deep South.", null, null, null, true, false, 1960, "To Kill a Mockingbird", 12, null, null },
                    { 3, null, null, 3, 12, 2, null, null, "A sweeping history of humanity from ancient times to the present.", null, null, null, true, false, 2011, "Sapiens: A Brief History of Humankind", 20, null, null },
                    { 4, null, null, 4, 5, 3, null, null, "A memoir about a woman who grows up in a survivalist family and eventually escapes for an education.", null, null, null, true, false, 2018, "Educated", 7, null, null },
                    { 5, null, null, 5, 15, 4, null, null, "A landmark book by physicist Stephen Hawking about the origins and nature of the universe.", null, null, null, true, false, 1988, "A Brief History of Time", 25, null, null },
                    { 6, null, null, 6, 8, 2, null, null, "A seminal work on evolutionary biology, focusing on the gene-centered view of evolution.", null, null, null, true, false, 1976, "The Selfish Gene", 12, null, null },
                    { 7, null, null, 7, 6, 4, null, null, "A book about the beauty and wonder of mathematics and its applications.", null, null, null, true, false, 2014, "The Joy of x", 9, null, null },
                    { 8, null, null, 8, 7, 5, null, null, "A novella exploring the nature of dimensions and our perception of reality.", null, null, null, true, false, 1884, "Flatland: A Romance of Many Dimensions", 10, null, null },
                    { 9, null, null, 9, 5, 6, null, null, "The diary of Anne Frank, chronicling her life in hiding during the Holocaust.", null, null, null, true, false, 1947, "The Diary of a Young Girl", 8, null, null },
                    { 10, null, null, 10, 12, 2, null, null, "A history of the world from the perspective of the Silk Roads trade routes.", null, null, null, true, false, 2015, "The Silk Roads", 18, null, null },
                    { 11, null, null, 11, 10, 7, null, null, "A biography of the Apple co-founder, written by Walter Isaacson.", null, null, null, true, false, 2011, "Steve Jobs", 15, null, null },
                    { 12, null, null, 12, 8, 6, null, null, "The life story of the influential civil rights leader, as told to journalist Alex Haley.", null, null, null, true, false, 1965, "The Autobiography of Malcolm X", 12, null, null },
                    { 13, null, null, 13, 6, 1, null, null, "Herman Melville's classic novel about the obsessive quest to capture the white whale.", null, null, null, true, false, 1851, "Moby-Dick", 10, null, null },
                    { 14, null, null, 14, 10, 1, null, null, "Jane Austen's timeless romantic novel set in the British Regency era.", null, null, null, true, false, 1813, "Pride and Prejudice", 14, null, null },
                    { 15, null, null, 15, 7, 4, null, null, "The personal writings of the Roman Emperor Marcus Aurelius on Stoic philosophy.", null, null, null, true, false, 180, "Meditations", 10, null, null },
                    { 16, null, null, 16, 8, 5, null, null, "Plato's philosophical dialogue about justice, the ideal state, and the nature of the human soul.", null, null, null, true, false, -380, "The Republic", 11, null, null },
                    { 17, null, null, 17, 10, 3, null, null, "A groundbreaking book on human decision-making and cognitive biases by Nobel laureate Daniel Kahneman.", null, null, null, true, false, 2011, "Thinking, Fast and Slow", 15, null, null },
                    { 18, null, null, 18, 9, 3, null, null, "A book exploring the science of habit formation and how it impacts our daily lives.", null, null, null, true, false, 2012, "The Power of Habit", 14, null, null },
                    { 19, null, null, 19, 10, 3, null, null, "James Clear's guide to breaking bad habits and building good ones through small, consistent changes.", null, null, null, true, false, 2018, "Atomic Habits", 15, null, null },
                    { 20, null, null, 20, 14, 3, null, null, "Stephen R. Covey's classic book on personal and professional effectiveness.", null, null, null, true, false, 1989, "The 7 Habits of Highly Effective People", 20, null, null },
                    { 21, null, null, 21, 8, 5, null, null, "An accessible introduction to the history of art by renowned art historian E.H. Gombrich.", null, null, null, true, false, 1950, "The Story of Art", 12, null, null },
                    { 22, null, null, 22, 6, 5, null, null, "A groundbreaking book on visual culture and how we perceive art, written by John Berger.", null, null, null, true, false, 1972, "Ways of Seeing", 9, null, null },
                    { 23, null, null, 23, 7, 4, null, null, "A history of 20th-century classical music by music critic Alex Ross.", null, null, null, true, false, 2007, "The Rest Is Noise", 10, null, null },
                    { 24, null, null, 24, 8, 4, null, null, "David Byrne’s exploration of music, its history, and its cultural impact.", null, null, null, true, false, 2012, "How Music Works", 12, null, null },
                    { 25, null, null, 25, 10, 3, null, null, "Bessel van der Kolk’s exploration of trauma and its effect on the brain and body.", null, null, null, true, false, 2014, "The Body Keeps the Score", 15, null, null },
                    { 26, null, null, 26, 6, 2, null, null, "A book about the science of running and the story of a remote tribe of ultra-runners.", null, null, null, true, false, 2009, "Born to Run", 10, null, null },
                    { 27, null, null, 27, 7, 8, null, null, "Irma S. Rombauer’s classic cookbook that has become an American institution.", null, null, null, true, false, 1931, "The Joy of Cooking", 11, null, null },
                    { 28, null, null, 28, 6, 14, null, null, "A guide to understanding the fundamental elements of cooking by Samin Nosrat.", null, null, null, true, false, 2017, "Salt, Fat, Acid, Heat", 8, null, null },
                    { 29, null, null, 29, 8, 8, null, null, "Anthony Bourdain’s behind-the-scenes look at the culinary world.", null, null, null, true, false, 2000, "Kitchen Confidential", 12, null, null },
                    { 30, null, null, 30, 10, 8, null, null, "Michael Pollan’s exploration of where our food comes from and its environmental impact.", null, null, null, true, false, 2006, "The Omnivore's Dilemma", 15, null, null },
                    { 31, null, null, 31, 7, 7, null, null, "Stephen King's memoir and guide to writing.", null, null, null, true, false, 2000, "On Writing", 10, null, null },
                    { 32, null, null, 32, 6, 7, null, null, "Anne Lamott's insightful and humorous take on writing and life.", null, null, null, true, false, 1994, "Bird by Bird", 9, null, null },
                    { 33, null, null, 33, 12, 7, null, null, "A concise guide to the principles of good writing, by William Strunk Jr. and E.B. White.", null, null, null, true, false, 1959, "The Elements of Style", 18, null, null },
                    { 34, null, null, 34, 8, 7, null, null, "Steven Pressfield’s book on overcoming resistance to creative work.", null, null, null, true, false, 2002, "The War of Art", 12, null, null },
                    { 35, null, null, 35, 15, 1, null, null, "Paulo Coelho's philosophical novel about pursuing your dreams and finding your destiny.", null, null, null, true, false, 1988, "The Alchemist", 20, null, null },
                    { 36, null, null, 36, 10, 1, null, null, "George Orwell's dystopian novel about totalitarianism, surveillance, and the power of propaganda.", null, null, null, true, false, 1949, "1984", 14, null, null },
                    { 37, null, null, 37, 8, 1, null, null, "Aldous Huxley's novel exploring a future society controlled by technology and conformity.", null, null, null, true, false, 1932, "Brave New World", 12, null, null },
                    { 38, null, null, 38, 9, 1, null, null, "Ray Bradbury's classic novel about a dystopian society where books are banned.", null, null, null, true, false, 1953, "Fahrenheit 451", 14, null, null },
                    { 39, null, null, 39, 12, 1, null, null, "J.D. Salinger's novel about teenage rebellion and disillusionment.", null, null, null, true, false, 1951, "The Catcher in the Rye", 18, null, null },
                    { 40, null, null, 40, 10, 1, null, null, "Margaret Atwood’s dystopian novel about gender oppression and the loss of personal freedom.", null, null, null, true, false, 1985, "The Handmaid's Tale", 15, null, null },
                    { 41, null, null, 41, 7, 1, null, null, "Cormac McCarthy's post-apocalyptic novel about a father and son struggling to survive.", null, null, null, true, false, 2006, "The Road", 10, null, null },
                    { 42, null, null, 42, 8, 1, null, null, "Kate Atkinson's novel about a woman who lives multiple lives in different timelines.", null, null, null, true, false, 2013, "Life After Life", 12, null, null },
                    { 43, null, null, 43, 9, 1, null, null, "Rick Yancey's thrilling novel about an alien invasion and the fight for survival.", null, null, null, true, false, 2013, "The 5th Wave", 14, null, null },
                    { 44, null, null, 44, 12, 1, null, null, "Suzanne Collins' dystopian novel about a televised fight to the death.", null, null, null, true, false, 2008, "The Hunger Games", 18, null, null },
                    { 45, null, null, 45, 10, 1, null, null, "Veronica Roth's novel set in a dystopian society divided into factions based on virtues.", null, null, null, true, false, 2011, "Divergent", 15, null, null },
                    { 46, null, null, 46, 8, 1, null, null, "Paula Hawkins' psychological thriller about a woman who gets involved in a missing person's case.", null, null, null, true, false, 2015, "The Girl on the Train", 12, null, null },
                    { 47, null, null, 47, 9, 1, null, null, "Gillian Flynn's mystery novel about a marriage gone wrong and the disappearance of a wife.", null, null, null, true, false, 2012, "Gone Girl", 14, null, null },
                    { 48, null, null, 48, 7, 1, null, null, "Gillian Flynn’s psychological thriller about a journalist returning to her hometown to investigate a series of murders.", null, null, null, true, false, 2006, "Sharp Objects", 10, null, null },
                    { 49, null, null, 49, 12, 1, null, null, "Liane Moriarty's novel about the secrets and lies in a tight-knit community.", null, null, null, true, false, 2014, "Big Little Lies", 18, null, null },
                    { 50, null, null, 50, 10, 1, null, null, "Stieg Larsson's crime thriller about a journalist and a hacker uncovering corruption in Sweden.", null, null, null, true, false, 2005, "The Girl with the Dragon Tattoo", 15, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
