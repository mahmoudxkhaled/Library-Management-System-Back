using LMS.DAL.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LMS.DAL;

public class LMSDbContext : IdentityDbContext<User>
{
    #region Constructors

    public LMSDbContext(DbContextOptions<LMSDbContext> options) : base(options)
    {

    }
    #endregion

    #region Entities

    public DbSet<Book> Book => Set<Book>();
    public DbSet<Category> Category => Set<Category>();
    public DbSet<Feedback> Feedback => Set<Feedback>();
    public DbSet<Transaction> Transaction => Set<Transaction>();
    public DbSet<TrendingBook> TrendingBooks => Set<TrendingBook>();
    public DbSet<User> User => Set<User>();
    public DbSet<Author> Authors => Set<Author>();


    #endregion

    #region OnModelCreating

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        #region Seeding Data
        #region Categories
        modelBuilder.Entity<Category>().HasData(
        new Category { Id = 1, Name = "Fiction", Description = "Books that contain stories created from the imagination." },
        new Category { Id = 2, Name = "Non-Fiction", Description = "Books based on real facts and events." },
        new Category { Id = 3, Name = "Science", Description = "Books related to scientific principles, experiments, and discoveries." },
        new Category { Id = 4, Name = "Mathematics", Description = "Books covering mathematical theories, problems, and equations." },
        new Category { Id = 5, Name = "History", Description = "Books that discuss past events and historical occurrences." },
        new Category { Id = 6, Name = "Biography", Description = "Books about the lives of individuals, either famous or historical." },
        new Category { Id = 7, Name = "Literature", Description = "Books considered to have artistic value, including poetry, novels, and drama." },
        new Category { Id = 8, Name = "Philosophy", Description = "Books that explore fundamental questions about existence, knowledge, and ethics." },
        new Category { Id = 9, Name = "Psychology", Description = "Books related to human behavior, emotions, and cognitive functions." },
        new Category { Id = 10, Name = "Self-Help", Description = "Books that provide advice or strategies for improving life and personal growth." },
        new Category { Id = 11, Name = "Art", Description = "Books that focus on various forms of art, including visual arts, sculpture, and performance." },
        new Category { Id = 12, Name = "Music", Description = "Books that discuss musical theory, history, and performance techniques." },
        new Category { Id = 13, Name = "Health & Fitness", Description = "Books focused on physical well-being, exercise, and mental health." },
        new Category { Id = 14, Name = "Cooking", Description = "Books providing recipes and cooking techniques." },
        new Category { Id = 15, Name = "Travel", Description = "Books that explore destinations, cultures, and experiences in different parts of the world." },
        new Category { Id = 16, Name = "Children's Books", Description = "Books intended for young readers, including stories and educational books." },
        new Category { Id = 17, Name = "Fantasy", Description = "Books containing magical or fantastical elements set in imaginary worlds." },
        new Category { Id = 18, Name = "Science Fiction", Description = "Books set in the future or in space, often incorporating advanced technology or extraterrestrial life." },
        new Category { Id = 19, Name = "Mystery", Description = "Books centered around solving a crime or uncovering secrets." },
        new Category { Id = 20, Name = "Thriller", Description = "Books designed to keep the reader on edge with suspense and tension." },
        new Category { Id = 21, Name = "Horror", Description = "Books designed to evoke fear or unease in the reader." },
        new Category { Id = 22, Name = "Poetry", Description = "Books containing poems, written in verse." },
        new Category { Id = 23, Name = "Religion", Description = "Books focused on religious studies, scriptures, and beliefs." },
        new Category { Id = 24, Name = "Spirituality", Description = "Books that explore personal growth and the search for meaning beyond the material world." },
        new Category { Id = 25, Name = "Politics", Description = "Books that explore political theory, history, and analysis." },
        new Category { Id = 26, Name = "Economics", Description = "Books about the production, distribution, and consumption of goods and services." },
        new Category { Id = 27, Name = "Business", Description = "Books on management, entrepreneurship, and business strategies." },
        new Category { Id = 28, Name = "Technology", Description = "Books covering advancements in technology, including programming, artificial intelligence, and gadgets." },
        new Category { Id = 29, Name = "Engineering", Description = "Books on engineering principles, innovations, and applications." },
        new Category { Id = 30, Name = "Law", Description = "Books about legal studies, statutes, and legal principles." },
        new Category { Id = 31, Name = "Photography", Description = "Books about the art and techniques of photography." },
        new Category { Id = 32, Name = "Architecture", Description = "Books on the design and construction of buildings and other structures." },
        new Category { Id = 33, Name = "Sports", Description = "Books about various sports, athletes, and sporting events." },
        new Category { Id = 34, Name = "Environment", Description = "Books focused on ecology, nature conservation, and environmental science." },
        new Category { Id = 35, Name = "Urban Studies", Description = "Books about cities, urban planning, and metropolitan life." },
        new Category { Id = 36, Name = "Economics & Finance", Description = "Books related to financial markets, investment strategies, and economic theory." },
        new Category { Id = 37, Name = "Parenting", Description = "Books offering advice for raising children and family dynamics." },
        new Category { Id = 38, Name = "Education", Description = "Books on educational methods, theories, and teaching practices." },
        new Category { Id = 39, Name = "Comic Books", Description = "Books consisting of illustrated stories in a comic strip format." },
        new Category { Id = 40, Name = "Graphic Novels", Description = "Books that combine illustrations with narrative storytelling, typically in a longer form." },
        new Category { Id = 41, Name = "Social Sciences", Description = "Books covering sociology, anthropology, and other social studies disciplines." },
        new Category { Id = 42, Name = "Linguistics", Description = "Books related to the scientific study of language and its structure." },
        new Category { Id = 43, Name = "Geography", Description = "Books about physical geography, the study of places and environments." },
        new Category { Id = 44, Name = "Space & Astronomy", Description = "Books about space exploration, the universe, stars, and planets." },
        new Category { Id = 45, Name = "Mathematical Fiction", Description = "Books that incorporate mathematical themes or problems in their stories." },
        new Category { Id = 46, Name = "Antiques & Collectibles", Description = "Books about the history and collection of valuable items." },
        new Category { Id = 47, Name = "Crafts & Hobbies", Description = "Books about various crafts, from knitting to woodworking." },
        new Category { Id = 48, Name = "Gardening", Description = "Books about planting, cultivating, and maintaining gardens." },
        new Category { Id = 49, Name = "Personal Finance", Description = "Books that focus on managing personal wealth, budgeting, and investing." },
        new Category { Id = 50, Name = "True Crime", Description = "Books that explore real-life criminal cases and investigations." }
            );
        #endregion
        #region Authors
        modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, FullName = "F. Scott Fitzgerald", DateOfBirth = new DateOnly(1896, 9, 1), Description = "American novelist, best known for 'The Great Gatsby.'" },
                new Author { Id = 2, FullName = "Harper Lee", DateOfBirth = new DateOnly(1926, 4, 20), Description = "American author of 'To Kill a Mockingbird.'" },
                new Author { Id = 3, FullName = "Yuval Noah Harari", DateOfBirth = new DateOnly(1976, 2, 24), Description = "Israeli historian and author of 'Sapiens.'" },
                new Author { Id = 4, FullName = "Tara Westover", DateOfBirth = new DateOnly(1986, 9, 27), Description = "American memoirist, known for 'Educated.'" },
                new Author { Id = 5, FullName = "Stephen Hawking", DateOfBirth = new DateOnly(1942, 1, 8), Description = "English theoretical physicist, known for 'A Brief History of Time.'" },
                new Author { Id = 6, FullName = "Richard Dawkins", DateOfBirth = new DateOnly(1941, 3, 26), Description = "English evolutionary biologist, author of 'The Selfish Gene.'" },
                new Author { Id = 7, FullName = "Steven Strogatz", DateOfBirth = new DateOnly(1959, 5, 13), Description = "American mathematician, author of 'The Joy of x.'" },
                new Author { Id = 8, FullName = "Edwin A. Abbott", DateOfBirth = new DateOnly(1838, 12, 20), Description = "English schoolmaster and theologian, known for 'Flatland.'" },
                new Author { Id = 9, FullName = "Anne Frank", DateOfBirth = new DateOnly(1929, 6, 12), Description = "Jewish diarist, known for 'The Diary of a Young Girl.'" },
                new Author { Id = 10, FullName = "Peter Frankopan", DateOfBirth = new DateOnly(1971, 8, 10), Description = "British historian, author of 'The Silk Roads.'" },
                new Author { Id = 11, FullName = "Walter Isaacson", DateOfBirth = new DateOnly(1952, 5, 20), Description = "American author and biographer, known for 'Steve Jobs.'" },
                new Author { Id = 12, FullName = "Malcolm X", DateOfBirth = new DateOnly(1925, 5, 19), Description = "African American civil rights leader, co-author of 'The Autobiography of Malcolm X.'" },
                new Author { Id = 13, FullName = "Herman Melville", DateOfBirth = new DateOnly(1819, 8, 1), Description = "American author, known for 'Moby-Dick.'" },
                new Author { Id = 14, FullName = "Jane Austen", DateOfBirth = new DateOnly(1775, 12, 16), Description = "English novelist, best known for 'Pride and Prejudice.'" },
                new Author { Id = 15, FullName = "Marcus Aurelius", DateOfBirth = new DateOnly(121, 4, 26), Description = "Roman Emperor, known for 'Meditations.'" },
                new Author { Id = 16, FullName = "Plato", DateOfBirth = new DateOnly(427, 5, 21), Description = "Ancient Greek philosopher, author of 'The Republic.'" },
                new Author { Id = 17, FullName = "Daniel Kahneman", DateOfBirth = new DateOnly(1934, 3, 5), Description = "Israeli-American psychologist, author of 'Thinking, Fast and Slow.'" },
                new Author { Id = 18, FullName = "Charles Duhigg", DateOfBirth = new DateOnly(1974, 4, 27), Description = "American journalist, author of 'The Power of Habit.'" },
                new Author { Id = 19, FullName = "James Clear", DateOfBirth = new DateOnly(1986, 7, 22), Description = "Author of 'Atomic Habits.'" },
                new Author { Id = 20, FullName = "Stephen R. Covey", DateOfBirth = new DateOnly(1932, 10, 24), Description = "American educator, author of 'The 7 Habits of Highly Effective People.'" },
                new Author { Id = 21, FullName = "E.H. Gombrich", DateOfBirth = new DateOnly(1909, 3, 20), Description = "Austrian-born British art historian, known for 'The Story of Art.'" },
                new Author { Id = 22, FullName = "John Berger", DateOfBirth = new DateOnly(1926, 11, 5), Description = "British art critic and theorist, author of 'Ways of Seeing.'" },
                new Author { Id = 23, FullName = "Alex Ross", DateOfBirth = new DateOnly(1968, 11, 10), Description = "American music critic, author of 'The Rest Is Noise.'" },
                new Author { Id = 24, FullName = "David Byrne", DateOfBirth = new DateOnly(1952, 5, 14), Description = "American musician and author of 'How Music Works.'" },
                new Author { Id = 25, FullName = "Bessel van der Kolk", DateOfBirth = new DateOnly(1943, 7, 5), Description = "Dutch-American psychiatrist, author of 'The Body Keeps the Score.'" },
                new Author { Id = 26, FullName = "Christopher McDougall", DateOfBirth = new DateOnly(1962, 6, 10), Description = "American author, known for 'Born to Run.'" },
                new Author { Id = 27, FullName = "Irma S. Rombauer", DateOfBirth = new DateOnly(1877, 3, 15), Description = "American author, known for 'The Joy of Cooking.'" },
                new Author { Id = 28, FullName = "Samin Nosrat", DateOfBirth = new DateOnly(1979, 11, 7), Description = "American chef and author of 'Salt, Fat, Acid, Heat.'" },
                new Author { Id = 29, FullName = "Jon Krakauer", DateOfBirth = new DateOnly(1954, 4, 12), Description = "American author, known for 'Into the Wild.'" },
                new Author { Id = 30, FullName = "Eric Weiner", DateOfBirth = new DateOnly(1962, 10, 26), Description = "American author, known for 'The Geography of Bliss.'" },
                new Author { Id = 31, FullName = "J.K. Rowling", DateOfBirth = new DateOnly(1965, 7, 20), Description = "British author, known for the 'Harry Potter' series." },
                new Author { Id = 32, FullName = "Maurice Sendak", DateOfBirth = new DateOnly(1928, 6, 10), Description = "American author of children's books, known for 'Where the Wild Things Are.'" },
                new Author { Id = 33, FullName = "J.R.R. Tolkien", DateOfBirth = new DateOnly(1892, 1, 3), Description = "English author, known for 'The Hobbit.'" },
                new Author { Id = 34, FullName = "Patrick Rothfuss", DateOfBirth = new DateOnly(1973, 6, 6), Description = "American author, known for 'The Name of the Wind.'" },
                new Author { Id = 35, FullName = "Frank Herbert", DateOfBirth = new DateOnly(1920, 10, 8), Description = "American science fiction author, known for 'Dune.'" },
                new Author { Id = 36, FullName = "William Gibson", DateOfBirth = new DateOnly(1948, 3, 17), Description = "American-Canadian author, known for 'Neuromancer.'" },
                new Author { Id = 37, FullName = "Stieg Larsson", DateOfBirth = new DateOnly(1954, 8, 15), Description = "Swedish author, known for 'The Girl with the Dragon Tattoo.'" },
                new Author { Id = 38, FullName = "Gillian Flynn", DateOfBirth = new DateOnly(1971, 2, 24), Description = "American author, known for 'Gone Girl.'" },
                new Author { Id = 39, FullName = "Alex Michaelides", DateOfBirth = new DateOnly(1968, 11, 22), Description = "Cypriot-British author, known for 'The Silent Patient.'" },
                new Author { Id = 40, FullName = "Paula Hawkins", DateOfBirth = new DateOnly(1972, 8, 26), Description = "British author, known for 'The Girl on the Train.'" },
                new Author { Id = 41, FullName = "Ray Bradbury", DateOfBirth = new DateOnly(1920, 8, 22), Description = "American author, known for 'Fahrenheit 451.'" },
                new Author { Id = 42, FullName = "George Orwell", DateOfBirth = new DateOnly(1903, 6, 25), Description = "British author, known for '1984.'" },
                new Author { Id = 43, FullName = "Aldous Huxley", DateOfBirth = new DateOnly(1894, 7, 26), Description = "English author, known for 'Brave New World.'" },
                new Author { Id = 44, FullName = "Margaret Atwood", DateOfBirth = new DateOnly(1939, 11, 18), Description = "Canadian author, known for 'The Handmaid's Tale.'" },
                new Author { Id = 45, FullName = "J.D. Salinger", DateOfBirth = new DateOnly(1919, 1, 1), Description = "American author, known for 'The Catcher in the Rye.'" },
                new Author { Id = 46, FullName = "S.E. Hinton", DateOfBirth = new DateOnly(1950, 7, 22), Description = "American author, known for 'The Outsiders.'" },
                new Author { Id = 47, FullName = "Oscar Wilde", DateOfBirth = new DateOnly(1854, 10, 16), Description = "Irish author, known for 'The Picture of Dorian Gray.'" },
                new Author { Id = 48, FullName = "Mary Shelley", DateOfBirth = new DateOnly(1797, 8, 20), Description = "English author, known for 'Frankenstein.'" },
                new Author { Id = 49, FullName = "Bram Stoker", DateOfBirth = new DateOnly(1847, 11, 8), Description = "Irish author, known for 'Dracula.'" },
                new Author { Id = 50, FullName = "Fyodor Dostoevsky", DateOfBirth = new DateOnly(1821, 11, 11), Description = "Russian author, known for 'Crime and Punishment.'" }
            );
        #endregion

        #region Books
        modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "The Great Gatsby", AuthorId = 1, Description = "A novel about the American dream and the Jazz Age.", PublicationYear = 1925, AvailableCopies = 10, TotalCopies = 15, CategoryId = 1 },
                new Book { Id = 2, Title = "To Kill a Mockingbird", AuthorId = 2, Description = "A novel about racial injustice in the Deep South.", PublicationYear = 1960, AvailableCopies = 8, TotalCopies = 12, CategoryId = 1 },
                new Book { Id = 3, Title = "Sapiens: A Brief History of Humankind", AuthorId = 3, Description = "A sweeping history of humanity from ancient times to the present.", PublicationYear = 2011, AvailableCopies = 12, TotalCopies = 20, CategoryId = 2 },
                new Book { Id = 4, Title = "Educated", AuthorId = 4, Description = "A memoir about a woman who grows up in a survivalist family and eventually escapes for an education.", PublicationYear = 2018, AvailableCopies = 5, TotalCopies = 7, CategoryId = 3 },
                new Book { Id = 5, Title = "A Brief History of Time", AuthorId = 5, Description = "A landmark book by physicist Stephen Hawking about the origins and nature of the universe.", PublicationYear = 1988, AvailableCopies = 15, TotalCopies = 25, CategoryId = 4 },
                new Book { Id = 6, Title = "The Selfish Gene", AuthorId = 6, Description = "A seminal work on evolutionary biology, focusing on the gene-centered view of evolution.", PublicationYear = 1976, AvailableCopies = 8, TotalCopies = 12, CategoryId = 2 },
                new Book { Id = 7, Title = "The Joy of x", AuthorId = 7, Description = "A book about the beauty and wonder of mathematics and its applications.", PublicationYear = 2014, AvailableCopies = 6, TotalCopies = 9, CategoryId = 4 },
                new Book { Id = 8, Title = "Flatland: A Romance of Many Dimensions", AuthorId = 8, Description = "A novella exploring the nature of dimensions and our perception of reality.", PublicationYear = 1884, AvailableCopies = 7, TotalCopies = 10, CategoryId = 5 },
                new Book { Id = 9, Title = "The Diary of a Young Girl", AuthorId = 9, Description = "The diary of Anne Frank, chronicling her life in hiding during the Holocaust.", PublicationYear = 1947, AvailableCopies = 5, TotalCopies = 8, CategoryId = 6 },
                new Book { Id = 10, Title = "The Silk Roads", AuthorId = 10, Description = "A history of the world from the perspective of the Silk Roads trade routes.", PublicationYear = 2015, AvailableCopies = 12, TotalCopies = 18, CategoryId = 2 },
                new Book { Id = 11, Title = "Steve Jobs", AuthorId = 11, Description = "A biography of the Apple co-founder, written by Walter Isaacson.", PublicationYear = 2011, AvailableCopies = 10, TotalCopies = 15, CategoryId = 7 },
                new Book { Id = 12, Title = "The Autobiography of Malcolm X", AuthorId = 12, Description = "The life story of the influential civil rights leader, as told to journalist Alex Haley.", PublicationYear = 1965, AvailableCopies = 8, TotalCopies = 12, CategoryId = 6 },
                new Book { Id = 13, Title = "Moby-Dick", AuthorId = 13, Description = "Herman Melville's classic novel about the obsessive quest to capture the white whale.", PublicationYear = 1851, AvailableCopies = 6, TotalCopies = 10, CategoryId = 1 },
                new Book { Id = 14, Title = "Pride and Prejudice", AuthorId = 14, Description = "Jane Austen's timeless romantic novel set in the British Regency era.", PublicationYear = 1813, AvailableCopies = 10, TotalCopies = 14, CategoryId = 1 },
                new Book { Id = 15, Title = "Meditations", AuthorId = 15, Description = "The personal writings of the Roman Emperor Marcus Aurelius on Stoic philosophy.", PublicationYear = 180, AvailableCopies = 7, TotalCopies = 10, CategoryId = 4 },
                new Book { Id = 16, Title = "The Republic", AuthorId = 16, Description = "Plato's philosophical dialogue about justice, the ideal state, and the nature of the human soul.", PublicationYear = -380, AvailableCopies = 8, TotalCopies = 11, CategoryId = 5 },
                new Book { Id = 17, Title = "Thinking, Fast and Slow", AuthorId = 17, Description = "A groundbreaking book on human decision-making and cognitive biases by Nobel laureate Daniel Kahneman.", PublicationYear = 2011, AvailableCopies = 10, TotalCopies = 15, CategoryId = 3 },
                new Book { Id = 18, Title = "The Power of Habit", AuthorId = 18, Description = "A book exploring the science of habit formation and how it impacts our daily lives.", PublicationYear = 2012, AvailableCopies = 9, TotalCopies = 14, CategoryId = 3 },
                new Book { Id = 19, Title = "Atomic Habits", AuthorId = 19, Description = "James Clear's guide to breaking bad habits and building good ones through small, consistent changes.", PublicationYear = 2018, AvailableCopies = 10, TotalCopies = 15, CategoryId = 3 },
                new Book { Id = 20, Title = "The 7 Habits of Highly Effective People", AuthorId = 20, Description = "Stephen R. Covey's classic book on personal and professional effectiveness.", PublicationYear = 1989, AvailableCopies = 14, TotalCopies = 20, CategoryId = 3 },
                new Book { Id = 21, Title = "The Story of Art", AuthorId = 21, Description = "An accessible introduction to the history of art by renowned art historian E.H. Gombrich.", PublicationYear = 1950, AvailableCopies = 8, TotalCopies = 12, CategoryId = 5 },
                new Book { Id = 22, Title = "Ways of Seeing", AuthorId = 22, Description = "A groundbreaking book on visual culture and how we perceive art, written by John Berger.", PublicationYear = 1972, AvailableCopies = 6, TotalCopies = 9, CategoryId = 5 },
                new Book { Id = 23, Title = "The Rest Is Noise", AuthorId = 23, Description = "A history of 20th-century classical music by music critic Alex Ross.", PublicationYear = 2007, AvailableCopies = 7, TotalCopies = 10, CategoryId = 4 },
                new Book { Id = 24, Title = "How Music Works", AuthorId = 24, Description = "David Byrne’s exploration of music, its history, and its cultural impact.", PublicationYear = 2012, AvailableCopies = 8, TotalCopies = 12, CategoryId = 4 },
                new Book { Id = 25, Title = "The Body Keeps the Score", AuthorId = 25, Description = "Bessel van der Kolk’s exploration of trauma and its effect on the brain and body.", PublicationYear = 2014, AvailableCopies = 10, TotalCopies = 15, CategoryId = 3 },
                new Book { Id = 26, Title = "Born to Run", AuthorId = 26, Description = "A book about the science of running and the story of a remote tribe of ultra-runners.", PublicationYear = 2009, AvailableCopies = 6, TotalCopies = 10, CategoryId = 2 },
                new Book { Id = 27, Title = "The Joy of Cooking", AuthorId = 27, Description = "Irma S. Rombauer’s classic cookbook that has become an American institution.", PublicationYear = 1931, AvailableCopies = 7, TotalCopies = 11, CategoryId = 8 },
                new Book { Id = 28, Title = "Salt, Fat, Acid, Heat", AuthorId = 28, Description = "A guide to understanding the fundamental elements of cooking by Samin Nosrat.", PublicationYear = 2017, AvailableCopies = 6, TotalCopies = 8, CategoryId = 14 },
                 new Book { Id = 29, Title = "Kitchen Confidential", AuthorId = 29, Description = "Anthony Bourdain’s behind-the-scenes look at the culinary world.", PublicationYear = 2000, AvailableCopies = 8, TotalCopies = 12, CategoryId = 8 },
                    new Book { Id = 30, Title = "The Omnivore's Dilemma", AuthorId = 30, Description = "Michael Pollan’s exploration of where our food comes from and its environmental impact.", PublicationYear = 2006, AvailableCopies = 10, TotalCopies = 15, CategoryId = 8 },
                    new Book { Id = 31, Title = "On Writing", AuthorId = 31, Description = "Stephen King's memoir and guide to writing.", PublicationYear = 2000, AvailableCopies = 7, TotalCopies = 10, CategoryId = 7 },
                    new Book { Id = 32, Title = "Bird by Bird", AuthorId = 32, Description = "Anne Lamott's insightful and humorous take on writing and life.", PublicationYear = 1994, AvailableCopies = 6, TotalCopies = 9, CategoryId = 7 },
                    new Book { Id = 33, Title = "The Elements of Style", AuthorId = 33, Description = "A concise guide to the principles of good writing, by William Strunk Jr. and E.B. White.", PublicationYear = 1959, AvailableCopies = 12, TotalCopies = 18, CategoryId = 7 },
                    new Book { Id = 34, Title = "The War of Art", AuthorId = 34, Description = "Steven Pressfield’s book on overcoming resistance to creative work.", PublicationYear = 2002, AvailableCopies = 8, TotalCopies = 12, CategoryId = 7 },
                    new Book { Id = 35, Title = "The Alchemist", AuthorId = 35, Description = "Paulo Coelho's philosophical novel about pursuing your dreams and finding your destiny.", PublicationYear = 1988, AvailableCopies = 15, TotalCopies = 20, CategoryId = 1 },
                    new Book { Id = 36, Title = "1984", AuthorId = 36, Description = "George Orwell's dystopian novel about totalitarianism, surveillance, and the power of propaganda.", PublicationYear = 1949, AvailableCopies = 10, TotalCopies = 14, CategoryId = 1 },
                    new Book { Id = 37, Title = "Brave New World", AuthorId = 37, Description = "Aldous Huxley's novel exploring a future society controlled by technology and conformity.", PublicationYear = 1932, AvailableCopies = 8, TotalCopies = 12, CategoryId = 1 },
                    new Book { Id = 38, Title = "Fahrenheit 451", AuthorId = 38, Description = "Ray Bradbury's classic novel about a dystopian society where books are banned.", PublicationYear = 1953, AvailableCopies = 9, TotalCopies = 14, CategoryId = 1 },
                    new Book { Id = 39, Title = "The Catcher in the Rye", AuthorId = 39, Description = "J.D. Salinger's novel about teenage rebellion and disillusionment.", PublicationYear = 1951, AvailableCopies = 12, TotalCopies = 18, CategoryId = 1 },
                    new Book { Id = 40, Title = "The Handmaid's Tale", AuthorId = 40, Description = "Margaret Atwood’s dystopian novel about gender oppression and the loss of personal freedom.", PublicationYear = 1985, AvailableCopies = 10, TotalCopies = 15, CategoryId = 1 },
                    new Book { Id = 41, Title = "The Road", AuthorId = 41, Description = "Cormac McCarthy's post-apocalyptic novel about a father and son struggling to survive.", PublicationYear = 2006, AvailableCopies = 7, TotalCopies = 10, CategoryId = 1 },
                    new Book { Id = 42, Title = "Life After Life", AuthorId = 42, Description = "Kate Atkinson's novel about a woman who lives multiple lives in different timelines.", PublicationYear = 2013, AvailableCopies = 8, TotalCopies = 12, CategoryId = 1 },
                    new Book { Id = 43, Title = "The 5th Wave", AuthorId = 43, Description = "Rick Yancey's thrilling novel about an alien invasion and the fight for survival.", PublicationYear = 2013, AvailableCopies = 9, TotalCopies = 14, CategoryId = 1 },
                    new Book { Id = 44, Title = "The Hunger Games", AuthorId = 44, Description = "Suzanne Collins' dystopian novel about a televised fight to the death.", PublicationYear = 2008, AvailableCopies = 12, TotalCopies = 18, CategoryId = 1 },
                    new Book { Id = 45, Title = "Divergent", AuthorId = 45, Description = "Veronica Roth's novel set in a dystopian society divided into factions based on virtues.", PublicationYear = 2011, AvailableCopies = 10, TotalCopies = 15, CategoryId = 1 },
                    new Book { Id = 46, Title = "The Girl on the Train", AuthorId = 46, Description = "Paula Hawkins' psychological thriller about a woman who gets involved in a missing person's case.", PublicationYear = 2015, AvailableCopies = 8, TotalCopies = 12, CategoryId = 1 },
                    new Book { Id = 47, Title = "Gone Girl", AuthorId = 47, Description = "Gillian Flynn's mystery novel about a marriage gone wrong and the disappearance of a wife.", PublicationYear = 2012, AvailableCopies = 9, TotalCopies = 14, CategoryId = 1 },
                    new Book { Id = 48, Title = "Sharp Objects", AuthorId = 48, Description = "Gillian Flynn’s psychological thriller about a journalist returning to her hometown to investigate a series of murders.", PublicationYear = 2006, AvailableCopies = 7, TotalCopies = 10, CategoryId = 1 },
                    new Book { Id = 49, Title = "Big Little Lies", AuthorId = 49, Description = "Liane Moriarty's novel about the secrets and lies in a tight-knit community.", PublicationYear = 2014, AvailableCopies = 12, TotalCopies = 18, CategoryId = 1 },
                    new Book { Id = 50, Title = "The Girl with the Dragon Tattoo", AuthorId = 50, Description = "Stieg Larsson's crime thriller about a journalist and a hacker uncovering corruption in Sweden.", PublicationYear = 2005, AvailableCopies = 10, TotalCopies = 15, CategoryId = 1 }
                );

        #endregion

        #endregion
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (typeof(ISharedColumns).IsAssignableFrom(entityType.ClrType) && entityType.BaseType == null)
                modelBuilder.Entity(entityType.ClrType).HasQueryFilter(CreateIsDeletedFilter(entityType.ClrType));
        }
    }
    #endregion

    private static LambdaExpression CreateIsDeletedFilter(Type entityType)
    {
        var parameter = Expression.Parameter(entityType, "e");
        var property = Expression.Property(parameter, nameof(ISharedColumns.IsDeleted));
        var comparison = Expression.MakeBinary(ExpressionType.Equal, property, Expression.Constant(false));
        return Expression.Lambda(comparison, parameter);
    }
}
