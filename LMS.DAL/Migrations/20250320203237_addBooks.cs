using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LMS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "ActivationTime", "ActivationUserId", "Author", "AvailableCopies", "CategoryId", "DeletedTime", "DeletedUserId", "Description", "ImageUrl", "InsertedTime", "InsertedUserId", "IsActive", "IsDeleted", "PublicationYear", "Title", "TotalCopies", "UpdateTime", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, null, null, "F. Scott Fitzgerald", 10, 1, null, null, "A novel about the American dream and the Jazz Age.", null, null, null, true, false, 1925, "The Great Gatsby", 15, null, null },
                    { 2, null, null, "Harper Lee", 8, 1, null, null, "A novel about racial injustice in the Deep South.", null, null, null, true, false, 1960, "To Kill a Mockingbird", 12, null, null },
                    { 3, null, null, "Yuval Noah Harari", 15, 2, null, null, "A compelling history of humankind from the Stone Age to the modern age.", null, null, null, true, false, 2011, "Sapiens: A Brief History of Humankind", 20, null, null },
                    { 4, null, null, "Tara Westover", 12, 2, null, null, "A memoir about a woman who grows up in a survivalist family and escapes to pursue an education.", null, null, null, true, false, 2018, "Educated", 15, null, null },
                    { 5, null, null, "Stephen Hawking", 10, 3, null, null, "A groundbreaking work on cosmology and the universe.", null, null, null, true, false, 1988, "A Brief History of Time", 12, null, null },
                    { 6, null, null, "Richard Dawkins", 8, 3, null, null, "A scientific book explaining evolution through the lens of gene-centered natural selection.", null, null, null, true, false, 1976, "The Selfish Gene", 10, null, null },
                    { 7, null, null, "Steven Strogatz", 6, 4, null, null, "A journey into the wonders of math, explaining mathematical concepts through engaging stories.", null, null, null, true, false, 2012, "The Joy of x", 10, null, null },
                    { 8, null, null, "Edwin A. Abbott", 5, 4, null, null, "A satire about a two-dimensional world that explores dimensions and geometric shapes.", null, null, null, true, false, 1884, "Flatland", 8, null, null },
                    { 9, null, null, "Anne Frank", 7, 5, null, null, "The famous wartime diary of a Jewish girl hiding from the Nazis.", null, null, null, true, false, 1947, "The Diary of a Young Girl", 10, null, null },
                    { 10, null, null, "Peter Frankopan", 9, 5, null, null, "A history of the world seen through the lens of the Silk Roads, the ancient trade routes that connected East and West.", null, null, null, true, false, 2015, "The Silk Roads", 12, null, null },
                    { 11, null, null, "Walter Isaacson", 5, 6, null, null, "A biography of the Apple founder Steve Jobs, exploring his complex personality and genius.", null, null, null, true, false, 2011, "Steve Jobs", 8, null, null },
                    { 12, null, null, "Malcolm X and Alex Haley", 7, 6, null, null, "The autobiography of civil rights leader Malcolm X, detailing his life and transformation.", null, null, null, true, false, 1965, "The Autobiography of Malcolm X", 10, null, null },
                    { 13, null, null, "Herman Melville", 4, 7, null, null, "A classic American novel about a captain’s obsession with hunting a white whale.", null, null, null, true, false, 1851, "Moby-Dick", 6, null, null },
                    { 14, null, null, "Jane Austen", 6, 7, null, null, "A novel about love, marriage, and society in 19th century England.", null, null, null, true, false, 1813, "Pride and Prejudice", 8, null, null },
                    { 15, null, null, "Marcus Aurelius", 5, 8, null, null, "The personal reflections of the Roman Emperor Marcus Aurelius on philosophy and leadership.", null, null, null, true, false, 180, "Meditations", 7, null, null },
                    { 16, null, null, "Plato", 4, 8, null, null, "A philosophical work that outlines the theory of justice and the ideal state.", null, null, null, true, false, -380, "The Republic", 6, null, null },
                    { 17, null, null, "Daniel Kahneman", 8, 9, null, null, "A look at the two systems of thought: the fast and intuitive, and the slow and deliberate.", null, null, null, true, false, 2011, "Thinking, Fast and Slow", 10, null, null },
                    { 18, null, null, "Charles Duhigg", 6, 9, null, null, "An exploration of the science behind why habits exist and how they can be changed.", null, null, null, true, false, 2012, "The Power of Habit", 8, null, null },
                    { 19, null, null, "James Clear", 12, 10, null, null, "A practical guide to building good habits and breaking bad ones.", null, null, null, true, false, 2018, "Atomic Habits", 15, null, null },
                    { 20, null, null, "Stephen R. Covey", 9, 10, null, null, "A guide to personal effectiveness and achieving your goals.", null, null, null, true, false, 1989, "The 7 Habits of Highly Effective People", 12, null, null },
                    { 21, null, null, "E.H. Gombrich", 6, 11, null, null, "An introduction to the world of art, explaining the development of art from ancient times to the modern era.", null, null, null, true, false, 1950, "The Story of Art", 8, null, null },
                    { 22, null, null, "John Berger", 5, 11, null, null, "An exploration of how we see and interpret art, challenging conventional views.", null, null, null, true, false, 1972, "Ways of Seeing", 7, null, null },
                    { 23, null, null, "Alex Ross", 4, 12, null, null, "A history of 20th-century music and its evolution, from the world wars to the present day.", null, null, null, true, false, 2007, "The Rest Is Noise", 6, null, null },
                    { 24, null, null, "David Byrne", 5, 12, null, null, "A book that explains the science, culture, and impact of music.", null, null, null, true, false, 2012, "How Music Works", 7, null, null },
                    { 25, null, null, "Bessel van der Kolk", 7, 13, null, null, "A book about trauma and how it affects the body and brain.", null, null, null, true, false, 2014, "The Body Keeps the Score", 10, null, null },
                    { 26, null, null, "Christopher McDougall", 8, 13, null, null, "A fascinating look at the world of ultramarathon running.", null, null, null, true, false, 2009, "Born to Run", 12, null, null },
                    { 27, null, null, "Irma S. Rombauer", 10, 14, null, null, "A classic cookbook that covers a wide range of recipes and cooking techniques.", null, null, null, true, false, 1931, "The Joy of Cooking", 12, null, null },
                    { 28, null, null, "Samin Nosrat", 6, 14, null, null, "A cookbook that teaches the fundamentals of cooking through four essential elements.", null, null, null, true, false, 2017, "Salt, Fat, Acid, Heat", 8, null, null },
                    { 29, null, null, "Jon Krakauer", 5, 15, null, null, "The true story of a young man who ventured into the Alaskan wilderness.", null, null, null, true, false, 1996, "Into the Wild", 8, null, null },
                    { 30, null, null, "Eric Weiner", 7, 15, null, null, "A travel memoir that seeks to discover the happiest places on Earth.", null, null, null, true, false, 2008, "The Geography of Bliss", 10, null, null },
                    { 31, null, null, "J.K. Rowling", 10, 16, null, null, "The first book in the Harry Potter series, where a young wizard discovers his magical heritage.", null, null, null, true, false, 1997, "Harry Potter and the Sorcerer's Stone", 15, null, null },
                    { 32, null, null, "Maurice Sendak", 5, 16, null, null, "A classic children's picture book about a boy who sails to an island of wild creatures.", null, null, null, true, false, 1963, "Where the Wild Things Are", 7, null, null },
                    { 33, null, null, "J.R.R. Tolkien", 7, 17, null, null, "A classic fantasy novel that follows Bilbo Baggins on an epic adventure.", null, null, null, true, false, 1937, "The Hobbit", 10, null, null },
                    { 34, null, null, "Patrick Rothfuss", 5, 17, null, null, "The first book in the Kingkiller Chronicle, a story of magic, music, and adventure.", null, null, null, true, false, 2007, "The Name of the Wind", 8, null, null },
                    { 35, null, null, "Frank Herbert", 6, 18, null, null, "A science fiction epic set in a distant future on a desert planet.", null, null, null, true, false, 1965, "Dune", 8, null, null },
                    { 36, null, null, "William Gibson", 4, 18, null, null, "A cyberpunk classic that helped define the genre and the concept of cyberspace.", null, null, null, true, false, 1984, "Neuromancer", 6, null, null },
                    { 37, null, null, "Stieg Larsson", 9, 19, null, null, "A gripping mystery about a journalist and a hacker investigating a missing person's case.", null, null, null, true, false, 2005, "The Girl with the Dragon Tattoo", 12, null, null },
                    { 38, null, null, "Gillian Flynn", 8, 19, null, null, "A psychological thriller about the disappearance of a woman and the secrets it uncovers.", null, null, null, true, false, 2012, "Gone Girl", 10, null, null },
                    { 39, null, null, "Alex Michaelides", 7, 20, null, null, "A psychological thriller about a woman who shoots her husband and then stops speaking.", null, null, null, true, false, 2019, "The Silent Patient", 10, null, null },
                    { 40, null, null, "Paula Hawkins", 6, 20, null, null, "A psychological thriller about a woman who becomes involved in a missing person case after witnessing something suspicious on a train.", null, null, null, true, false, 2015, "The Girl on the Train", 8, null, null },
                    { 41, null, null, "Ray Bradbury", 7, 21, null, null, "A dystopian novel about a future society where books are banned and burned.", null, null, null, true, false, 1953, "Fahrenheit 451", 10, null, null },
                    { 42, null, null, "George Orwell", 6, 21, null, null, "A novel about a totalitarian regime that uses surveillance and mind control.", null, null, null, true, false, 1949, "1984", 8, null, null },
                    { 43, null, null, "Aldous Huxley", 8, 22, null, null, "A novel about a utopian society that sacrifices individual freedom for comfort and stability.", null, null, null, true, false, 1932, "Brave New World", 10, null, null },
                    { 44, null, null, "Margaret Atwood", 5, 22, null, null, "A dystopian novel about a society that controls women’s reproductive rights.", null, null, null, true, false, 1985, "The Handmaid's Tale", 8, null, null },
                    { 45, null, null, "J.D. Salinger", 7, 7, null, null, "A novel about a teenage boy's rebellion against society and his quest for meaning.", null, null, null, true, false, 1951, "The Catcher in the Rye", 10, null, null },
                    { 46, null, null, "S.E. Hinton", 6, 7, null, null, "A coming-of-age story about a group of teenagers in a divided society.", null, null, null, true, false, 1967, "The Outsiders", 8, null, null },
                    { 47, null, null, "Oscar Wilde", 4, 7, null, null, "A novel about a man whose portrait ages while he remains youthful, as he lives a life of hedonism and sin.", null, null, null, true, false, 1890, "The Picture of Dorian Gray", 6, null, null },
                    { 48, null, null, "Mary Shelley", 5, 7, null, null, "The classic tale of a scientist who creates a living being, with disastrous consequences.", null, null, null, true, false, 1818, "Frankenstein", 7, null, null },
                    { 49, null, null, "Bram Stoker", 4, 7, null, null, "The gothic horror novel about the infamous vampire Count Dracula.", null, null, null, true, false, 1897, "Dracula", 6, null, null },
                    { 50, null, null, "Fyodor Dostoevsky", 6, 7, null, null, "A psychological novel about guilt and redemption, focusing on a man who commits murder.", null, null, null, true, false, 1866, "Crime and Punishment", 8, null, null },
                    { 51, null, null, "Leo Tolstoy", 5, 7, null, null, "A historical novel that follows the lives of several aristocratic families during the Napoleonic Wars.", null, null, null, true, false, 1869, "War and Peace", 7, null, null },
                    { 52, null, null, "Leo Tolstoy", 6, 7, null, null, "A tragic novel about love, family, and society in 19th-century Russia.", null, null, null, true, false, 1877, "Anna Karenina", 8, null, null },
                    { 53, null, null, "Fyodor Dostoevsky", 4, 7, null, null, "A philosophical novel that explores themes of faith, doubt, and morality through the lives of three brothers.", null, null, null, true, false, 1880, "The Brothers Karamazov", 6, null, null },
                    { 54, null, null, "Homer", 5, 8, null, null, "An ancient Greek epic poem about Odysseus's long journey home after the Trojan War.", null, null, null, true, false, -800, "The Odyssey", 7, null, null },
                    { 55, null, null, "Homer", 6, 8, null, null, "An epic poem about the events during the Trojan War, focusing on the hero Achilles.", null, null, null, true, false, -750, "The Iliad", 8, null, null },
                    { 56, null, null, "Sun Tzu", 7, 9, null, null, "An ancient Chinese treatise on military strategy and tactics.", null, null, null, true, false, -500, "The Art of War", 10, null, null },
                    { 57, null, null, "Niccolò Machiavelli", 6, 9, null, null, "A political treatise about power and leadership, offering advice to rulers.", null, null, null, true, false, 1532, "The Prince", 8, null, null },
                    { 58, null, null, "Robert Greene", 8, 10, null, null, "A guide to gaining and maintaining power, based on historical examples.", null, null, null, true, false, 1998, "The 48 Laws of Power", 10, null, null },
                    { 59, null, null, "Dale Carnegie", 9, 10, null, null, "A timeless self-help book on building relationships and influencing others.", null, null, null, true, false, 1936, "How to Win Friends and Influence People", 12, null, null },
                    { 60, null, null, "Eric Ries", 6, 10, null, null, "A guide for entrepreneurs on how to create successful startups by using lean principles.", null, null, null, true, false, 2011, "The Lean Startup", 8, null, null },
                    { 61, null, null, "Mark Manson", 7, 10, null, null, "A self-help book that teaches readers to focus on what really matters in life.", null, null, null, true, false, 2016, "The Subtle Art of Not Giving a F*ck", 10, null, null },
                    { 62, null, null, "Viktor Frankl", 8, 10, null, null, "A psychiatrist's account of his experiences in Nazi concentration camps and his exploration of finding meaning in life.", null, null, null, true, false, 1946, "Man's Search for Meaning", 12, null, null },
                    { 63, null, null, "H. W. Janson", 6, 11, null, null, "A comprehensive history of art from ancient times to the modern era.", null, null, null, true, false, 1962, "The History of Art", 8, null, null },
                    { 64, null, null, "R. Buckminster Fuller", 5, 11, null, null, "A book that explores the geometrical principles behind art, design, and architecture.", null, null, null, true, false, 1975, "The Painter's Secret Geometry", 7, null, null },
                    { 65, null, null, "Julia Cameron", 6, 11, null, null, "A guide to creative recovery and artistic self-expression.", null, null, null, true, false, 1992, "The Artist's Way", 8, null, null },
                    { 66, null, null, "Friedrich Nietzsche", 7, 8, null, null, "A philosophical work exploring the nature of Greek tragedy and the dichotomy between Apollonian and Dionysian forces.", null, null, null, true, false, 1872, "The Birth of Tragedy", 10, null, null },
                    { 67, null, null, "Howard Lindsay", 5, 12, null, null, "A musical that tells the story of the von Trapp family and their escape from Nazi Austria.", null, null, null, true, false, 1959, "The Sound of Music", 7, null, null },
                    { 68, null, null, "Ludwig van Beethoven", 6, 12, null, null, "A collection of letters written by Beethoven, offering insights into his life and work.", null, null, null, true, false, 1985, "Beethoven's Letters", 8, null, null },
                    { 69, null, null, "Gerald Klickstein", 7, 12, null, null, "A guide to practicing, performing, and maintaining a successful musical career.", null, null, null, true, false, 2009, "The Musician's Way", 10, null, null },
                    { 70, null, null, "Kristin McClellan", 5, 12, null, null, "A book that explores the therapeutic benefits of music and its use in healing.", null, null, null, true, false, 2016, "The Healing Power of Music", 8, null, null },
                    { 71, null, null, "Christopher McDougall", 6, 13, null, null, "A fascinating look at the world of ultramarathon running.", null, null, null, true, false, 2009, "Born to Run", 8, null, null },
                    { 72, null, null, "Nicholas Romanov", 7, 13, null, null, "A book on the science of running, focusing on proper technique to avoid injury.", null, null, null, true, false, 2012, "The Running Revolution", 10, null, null },
                    { 73, null, null, "David Epstein", 5, 13, null, null, "An exploration of the genetic and environmental factors that contribute to athletic success.", null, null, null, true, false, 2013, "The Sports Gene", 7, null, null },
                    { 74, null, null, "Steven Pressfield", 6, 14, null, null, "A guide to overcoming creative resistance and achieving artistic success.", null, null, null, true, false, 2002, "The War of Art", 8, null, null },
                    { 75, null, null, "Michael Pollan", 7, 14, null, null, "A book about cooking, exploring the science and art of food preparation.", null, null, null, true, false, 2013, "Cooked", 10, null, null },
                    { 76, null, null, "Peter Barham", 6, 14, null, null, "A book that explains the scientific principles behind cooking techniques.", null, null, null, true, false, 2001, "The Science of Cooking", 8, null, null },
                    { 77, null, null, "Sarah Kieffer", 8, 14, null, null, "A baking book filled with delicious recipes and baking tips.", null, null, null, true, false, 2017, "The Joy of Baking", 10, null, null },
                    { 78, null, null, "Jon Krakauer", 9, 15, null, null, "A personal account of a disastrous expedition to Mount Everest.", null, null, null, true, false, 1997, "Into Thin Air", 12, null, null },
                    { 79, null, null, "Bruce Chatwin", 6, 15, null, null, "A travelogue about the author's journey through the wild and remote region of Patagonia.", null, null, null, true, false, 1977, "In Patagonia", 8, null, null },
                    { 80, null, null, "Bill Bryson", 7, 15, null, null, "A humorous account of the author's attempt to hike the Appalachian Trail.", null, null, null, true, false, 1998, "A Walk in the Woods", 10, null, null },
                    { 81, null, null, "Frances Hodgson Burnett", 8, 16, null, null, "A beloved children's novel about a young girl who discovers a magical garden.", null, null, null, true, false, 1911, "The Secret Garden", 10, null, null },
                    { 82, null, null, "Lewis Carroll", 5, 16, null, null, "A whimsical story of a young girl who falls into a fantastical world.", null, null, null, true, false, 1865, "Alice's Adventures in Wonderland", 7, null, null },
                    { 83, null, null, "C.S. Lewis", 6, 16, null, null, "The first book in The Chronicles of Narnia series, where four siblings enter a magical world through a wardrobe.", null, null, null, true, false, 1950, "The Lion, the Witch and the Wardrobe", 8, null, null },
                    { 84, null, null, "Kenneth Grahame", 7, 16, null, null, "A children's novel about the adventures of Mole, Rat, Badger, and Toad in the English countryside.", null, null, null, true, false, 1908, "The Wind in the Willows", 10, null, null },
                    { 85, null, null, "E.B. White", 9, 16, null, null, "A touching story about a pig named Wilbur and his friendship with a spider named Charlotte.", null, null, null, true, false, 1952, "Charlotte's Web", 12, null, null },
                    { 86, null, null, "J.R.R. Tolkien", 10, 17, null, null, "The classic fantasy novel about the adventures of Bilbo Baggins.", null, null, null, true, false, 1937, "The Hobbit", 12, null, null },
                    { 87, null, null, "J.R.R. Tolkien", 5, 17, null, null, "The first book in The Lord of the Rings series, about the journey to destroy a powerful ring.", null, null, null, true, false, 1954, "The Fellowship of the Ring", 7, null, null },
                    { 88, null, null, "J.R.R. Tolkien", 6, 17, null, null, "The second book in The Lord of the Rings series, continuing the journey to destroy the One Ring.", null, null, null, true, false, 1954, "The Two Towers", 8, null, null },
                    { 89, null, null, "J.R.R. Tolkien", 7, 17, null, null, "The final book in The Lord of the Rings series, concluding the epic quest to defeat Sauron.", null, null, null, true, false, 1955, "The Return of the King", 10, null, null },
                    { 90, null, null, "J.R.R. Tolkien", 8, 17, null, null, "A prequel to The Lord of the Rings series, telling the story of Bilbo's adventure.", null, null, null, true, false, 1937, "The Hobbit: An Unexpected Journey", 10, null, null },
                    { 91, null, null, "Margaret Atwood", 9, 22, null, null, "A dystopian novel set in a totalitarian society that controls women's rights and freedoms.", null, null, null, true, false, 1985, "The Handmaid's Tale", 12, null, null },
                    { 92, null, null, "George Orwell", 6, 21, null, null, "A dystopian novel about a totalitarian regime where surveillance is constant and free thought is restricted.", null, null, null, true, false, 1949, "1984", 8, null, null },
                    { 93, null, null, "Aldous Huxley", 8, 22, null, null, "A vision of a future society where happiness is achieved through artificial means, and individualism is sacrificed.", null, null, null, true, false, 1932, "Brave New World", 10, null, null },
                    { 94, null, null, "Suzanne Collins", 7, 22, null, null, "A dystopian novel set in a world where children are chosen to fight in a televised gladiatorial contest.", null, null, null, true, false, 2008, "The Hunger Games", 10, null, null },
                    { 95, null, null, "Lois Lowry", 6, 22, null, null, "A dystopian novel about a boy who begins to question the nature of his world after being chosen as the Receiver of Memory.", null, null, null, true, false, 1993, "The Giver", 8, null, null },
                    { 96, null, null, "Cormac McCarthy", 5, 22, null, null, "A post-apocalyptic novel about a father and son struggling to survive in a bleak, desolate world.", null, null, null, true, false, 2006, "The Road", 7, null, null },
                    { 97, null, null, "Ray Bradbury", 8, 21, null, null, "A futuristic novel where books are banned, and firemen burn any that are found.", null, null, null, true, false, 1953, "Fahrenheit 451", 10, null, null },
                    { 98, null, null, "James Dashner", 7, 22, null, null, "A dystopian novel about a group of teens trapped in a maze with no memory of how they got there.", null, null, null, true, false, 2009, "The Maze Runner", 10, null, null },
                    { 99, null, null, "Veronica Roth", 6, 22, null, null, "A young adult dystopian novel set in a society where people are divided into factions based on their virtues.", null, null, null, true, false, 2011, "Divergent", 8, null, null },
                    { 100, null, null, "Jeanne DuPrau", 7, 22, null, null, "A post-apocalyptic novel about a city running out of power and the young people trying to escape.", null, null, null, true, false, 2003, "The City of Ember", 10, null, null }
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

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
