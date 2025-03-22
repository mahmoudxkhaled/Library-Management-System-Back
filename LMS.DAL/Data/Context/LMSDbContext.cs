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
        #region Books
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Description = "A novel about the American dream and the Jazz Age.", PublicationYear = 1925, AvailableCopies = 10, TotalCopies = 15, CategoryId = 1 },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Description = "A novel about racial injustice in the Deep South.", PublicationYear = 1960, AvailableCopies = 8, TotalCopies = 12, CategoryId = 1 },
            new Book { Id = 3, Title = "Sapiens: A Brief History of Humankind", Author = "Yuval Noah Harari", Description = "A compelling history of humankind from the Stone Age to the modern age.", PublicationYear = 2011, AvailableCopies = 15, TotalCopies = 20, CategoryId = 2 },
            new Book { Id = 4, Title = "Educated", Author = "Tara Westover", Description = "A memoir about a woman who grows up in a survivalist family and escapes to pursue an education.", PublicationYear = 2018, AvailableCopies = 12, TotalCopies = 15, CategoryId = 2 },
            new Book { Id = 5, Title = "A Brief History of Time", Author = "Stephen Hawking", Description = "A groundbreaking work on cosmology and the universe.", PublicationYear = 1988, AvailableCopies = 10, TotalCopies = 12, CategoryId = 3 },
            new Book { Id = 6, Title = "The Selfish Gene", Author = "Richard Dawkins", Description = "A scientific book explaining evolution through the lens of gene-centered natural selection.", PublicationYear = 1976, AvailableCopies = 8, TotalCopies = 10, CategoryId = 3 },
            new Book { Id = 7, Title = "The Joy of x", Author = "Steven Strogatz", Description = "A journey into the wonders of math, explaining mathematical concepts through engaging stories.", PublicationYear = 2012, AvailableCopies = 6, TotalCopies = 10, CategoryId = 4 },
            new Book { Id = 8, Title = "Flatland", Author = "Edwin A. Abbott", Description = "A satire about a two-dimensional world that explores dimensions and geometric shapes.", PublicationYear = 1884, AvailableCopies = 5, TotalCopies = 8, CategoryId = 4 },
            new Book { Id = 9, Title = "The Diary of a Young Girl", Author = "Anne Frank", Description = "The famous wartime diary of a Jewish girl hiding from the Nazis.", PublicationYear = 1947, AvailableCopies = 7, TotalCopies = 10, CategoryId = 5 },
            new Book { Id = 10, Title = "The Silk Roads", Author = "Peter Frankopan", Description = "A history of the world seen through the lens of the Silk Roads, the ancient trade routes that connected East and West.", PublicationYear = 2015, AvailableCopies = 9, TotalCopies = 12, CategoryId = 5 },
            new Book { Id = 11, Title = "Steve Jobs", Author = "Walter Isaacson", Description = "A biography of the Apple founder Steve Jobs, exploring his complex personality and genius.", PublicationYear = 2011, AvailableCopies = 5, TotalCopies = 8, CategoryId = 6 },
            new Book { Id = 12, Title = "The Autobiography of Malcolm X", Author = "Malcolm X and Alex Haley", Description = "The autobiography of civil rights leader Malcolm X, detailing his life and transformation.", PublicationYear = 1965, AvailableCopies = 7, TotalCopies = 10, CategoryId = 6 },
            new Book { Id = 13, Title = "Moby-Dick", Author = "Herman Melville", Description = "A classic American novel about a captain’s obsession with hunting a white whale.", PublicationYear = 1851, AvailableCopies = 4, TotalCopies = 6, CategoryId = 7 },
            new Book { Id = 14, Title = "Pride and Prejudice", Author = "Jane Austen", Description = "A novel about love, marriage, and society in 19th century England.", PublicationYear = 1813, AvailableCopies = 6, TotalCopies = 8, CategoryId = 7 },
            new Book { Id = 15, Title = "Meditations", Author = "Marcus Aurelius", Description = "The personal reflections of the Roman Emperor Marcus Aurelius on philosophy and leadership.", PublicationYear = 180, AvailableCopies = 5, TotalCopies = 7, CategoryId = 8 },
            new Book { Id = 16, Title = "The Republic", Author = "Plato", Description = "A philosophical work that outlines the theory of justice and the ideal state.", PublicationYear = -380, AvailableCopies = 4, TotalCopies = 6, CategoryId = 8 },
            new Book { Id = 17, Title = "Thinking, Fast and Slow", Author = "Daniel Kahneman", Description = "A look at the two systems of thought: the fast and intuitive, and the slow and deliberate.", PublicationYear = 2011, AvailableCopies = 8, TotalCopies = 10, CategoryId = 9 },
            new Book { Id = 18, Title = "The Power of Habit", Author = "Charles Duhigg", Description = "An exploration of the science behind why habits exist and how they can be changed.", PublicationYear = 2012, AvailableCopies = 6, TotalCopies = 8, CategoryId = 9 },
            new Book { Id = 19, Title = "Atomic Habits", Author = "James Clear", Description = "A practical guide to building good habits and breaking bad ones.", PublicationYear = 2018, AvailableCopies = 12, TotalCopies = 15, CategoryId = 10 },
            new Book { Id = 20, Title = "The 7 Habits of Highly Effective People", Author = "Stephen R. Covey", Description = "A guide to personal effectiveness and achieving your goals.", PublicationYear = 1989, AvailableCopies = 9, TotalCopies = 12, CategoryId = 10 },
            new Book { Id = 21, Title = "The Story of Art", Author = "E.H. Gombrich", Description = "An introduction to the world of art, explaining the development of art from ancient times to the modern era.", PublicationYear = 1950, AvailableCopies = 6, TotalCopies = 8, CategoryId = 11 },
            new Book { Id = 22, Title = "Ways of Seeing", Author = "John Berger", Description = "An exploration of how we see and interpret art, challenging conventional views.", PublicationYear = 1972, AvailableCopies = 5, TotalCopies = 7, CategoryId = 11 },
            new Book { Id = 23, Title = "The Rest Is Noise", Author = "Alex Ross", Description = "A history of 20th-century music and its evolution, from the world wars to the present day.", PublicationYear = 2007, AvailableCopies = 4, TotalCopies = 6, CategoryId = 12 },
            new Book { Id = 24, Title = "How Music Works", Author = "David Byrne", Description = "A book that explains the science, culture, and impact of music.", PublicationYear = 2012, AvailableCopies = 5, TotalCopies = 7, CategoryId = 12 },
            new Book { Id = 25, Title = "The Body Keeps the Score", Author = "Bessel van der Kolk", Description = "A book about trauma and how it affects the body and brain.", PublicationYear = 2014, AvailableCopies = 7, TotalCopies = 10, CategoryId = 13 },
            new Book { Id = 26, Title = "Born to Run", Author = "Christopher McDougall", Description = "A fascinating look at the world of ultramarathon running.", PublicationYear = 2009, AvailableCopies = 8, TotalCopies = 12, CategoryId = 13 },
            new Book { Id = 27, Title = "The Joy of Cooking", Author = "Irma S. Rombauer", Description = "A classic cookbook that covers a wide range of recipes and cooking techniques.", PublicationYear = 1931, AvailableCopies = 10, TotalCopies = 12, CategoryId = 14 },
            new Book { Id = 28, Title = "Salt, Fat, Acid, Heat", Author = "Samin Nosrat", Description = "A cookbook that teaches the fundamentals of cooking through four essential elements.", PublicationYear = 2017, AvailableCopies = 6, TotalCopies = 8, CategoryId = 14 },
            new Book { Id = 29, Title = "Into the Wild", Author = "Jon Krakauer", Description = "The true story of a young man who ventured into the Alaskan wilderness.", PublicationYear = 1996, AvailableCopies = 5, TotalCopies = 8, CategoryId = 15 },
            new Book { Id = 30, Title = "The Geography of Bliss", Author = "Eric Weiner", Description = "A travel memoir that seeks to discover the happiest places on Earth.", PublicationYear = 2008, AvailableCopies = 7, TotalCopies = 10, CategoryId = 15 },
            new Book { Id = 31, Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling", Description = "The first book in the Harry Potter series, where a young wizard discovers his magical heritage.", PublicationYear = 1997, AvailableCopies = 10, TotalCopies = 15, CategoryId = 16 },
            new Book { Id = 32, Title = "Where the Wild Things Are", Author = "Maurice Sendak", Description = "A classic children's picture book about a boy who sails to an island of wild creatures.", PublicationYear = 1963, AvailableCopies = 5, TotalCopies = 7, CategoryId = 16 },
            new Book { Id = 33, Title = "The Hobbit", Author = "J.R.R. Tolkien", Description = "A classic fantasy novel that follows Bilbo Baggins on an epic adventure.", PublicationYear = 1937, AvailableCopies = 7, TotalCopies = 10, CategoryId = 17 },
            new Book { Id = 34, Title = "The Name of the Wind", Author = "Patrick Rothfuss", Description = "The first book in the Kingkiller Chronicle, a story of magic, music, and adventure.", PublicationYear = 2007, AvailableCopies = 5, TotalCopies = 8, CategoryId = 17 },
            new Book { Id = 35, Title = "Dune", Author = "Frank Herbert", Description = "A science fiction epic set in a distant future on a desert planet.", PublicationYear = 1965, AvailableCopies = 6, TotalCopies = 8, CategoryId = 18 },
            new Book { Id = 36, Title = "Neuromancer", Author = "William Gibson", Description = "A cyberpunk classic that helped define the genre and the concept of cyberspace.", PublicationYear = 1984, AvailableCopies = 4, TotalCopies = 6, CategoryId = 18 },
            new Book { Id = 37, Title = "The Girl with the Dragon Tattoo", Author = "Stieg Larsson", Description = "A gripping mystery about a journalist and a hacker investigating a missing person's case.", PublicationYear = 2005, AvailableCopies = 9, TotalCopies = 12, CategoryId = 19 },
            new Book { Id = 38, Title = "Gone Girl", Author = "Gillian Flynn", Description = "A psychological thriller about the disappearance of a woman and the secrets it uncovers.", PublicationYear = 2012, AvailableCopies = 8, TotalCopies = 10, CategoryId = 19 },
            new Book { Id = 39, Title = "The Silent Patient", Author = "Alex Michaelides", Description = "A psychological thriller about a woman who shoots her husband and then stops speaking.", PublicationYear = 2019, AvailableCopies = 7, TotalCopies = 10, CategoryId = 20 },
            new Book { Id = 40, Title = "The Girl on the Train", Author = "Paula Hawkins", Description = "A psychological thriller about a woman who becomes involved in a missing person case after witnessing something suspicious on a train.", PublicationYear = 2015, AvailableCopies = 6, TotalCopies = 8, CategoryId = 20 },
            new Book { Id = 41, Title = "Fahrenheit 451", Author = "Ray Bradbury", Description = "A dystopian novel about a future society where books are banned and burned.", PublicationYear = 1953, AvailableCopies = 7, TotalCopies = 10, CategoryId = 21 },
            new Book { Id = 42, Title = "1984", Author = "George Orwell", Description = "A novel about a totalitarian regime that uses surveillance and mind control.", PublicationYear = 1949, AvailableCopies = 6, TotalCopies = 8, CategoryId = 21 },
            new Book { Id = 43, Title = "Brave New World", Author = "Aldous Huxley", Description = "A novel about a utopian society that sacrifices individual freedom for comfort and stability.", PublicationYear = 1932, AvailableCopies = 8, TotalCopies = 10, CategoryId = 22 },
            new Book { Id = 44, Title = "The Handmaid's Tale", Author = "Margaret Atwood", Description = "A dystopian novel about a society that controls women’s reproductive rights.", PublicationYear = 1985, AvailableCopies = 5, TotalCopies = 8, CategoryId = 22 },
            new Book { Id = 45, Title = "The Catcher in the Rye", Author = "J.D. Salinger", Description = "A novel about a teenage boy's rebellion against society and his quest for meaning.", PublicationYear = 1951, AvailableCopies = 7, TotalCopies = 10, CategoryId = 7 },
            new Book { Id = 46, Title = "The Outsiders", Author = "S.E. Hinton", Description = "A coming-of-age story about a group of teenagers in a divided society.", PublicationYear = 1967, AvailableCopies = 6, TotalCopies = 8, CategoryId = 7 },
            new Book { Id = 47, Title = "The Picture of Dorian Gray", Author = "Oscar Wilde", Description = "A novel about a man whose portrait ages while he remains youthful, as he lives a life of hedonism and sin.", PublicationYear = 1890, AvailableCopies = 4, TotalCopies = 6, CategoryId = 7 },
            new Book { Id = 48, Title = "Frankenstein", Author = "Mary Shelley", Description = "The classic tale of a scientist who creates a living being, with disastrous consequences.", PublicationYear = 1818, AvailableCopies = 5, TotalCopies = 7, CategoryId = 7 },
            new Book { Id = 49, Title = "Dracula", Author = "Bram Stoker", Description = "The gothic horror novel about the infamous vampire Count Dracula.", PublicationYear = 1897, AvailableCopies = 4, TotalCopies = 6, CategoryId = 7 },
            new Book { Id = 50, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Description = "A psychological novel about guilt and redemption, focusing on a man who commits murder.", PublicationYear = 1866, AvailableCopies = 6, TotalCopies = 8, CategoryId = 7 },
            new Book { Id = 51, Title = "War and Peace", Author = "Leo Tolstoy", Description = "A historical novel that follows the lives of several aristocratic families during the Napoleonic Wars.", PublicationYear = 1869, AvailableCopies = 5, TotalCopies = 7, CategoryId = 7 },
            new Book { Id = 52, Title = "Anna Karenina", Author = "Leo Tolstoy", Description = "A tragic novel about love, family, and society in 19th-century Russia.", PublicationYear = 1877, AvailableCopies = 6, TotalCopies = 8, CategoryId = 7 },
            new Book { Id = 53, Title = "The Brothers Karamazov", Author = "Fyodor Dostoevsky", Description = "A philosophical novel that explores themes of faith, doubt, and morality through the lives of three brothers.", PublicationYear = 1880, AvailableCopies = 4, TotalCopies = 6, CategoryId = 7 },
            new Book { Id = 54, Title = "The Odyssey", Author = "Homer", Description = "An ancient Greek epic poem about Odysseus's long journey home after the Trojan War.", PublicationYear = -800, AvailableCopies = 5, TotalCopies = 7, CategoryId = 8 },
            new Book { Id = 55, Title = "The Iliad", Author = "Homer", Description = "An epic poem about the events during the Trojan War, focusing on the hero Achilles.", PublicationYear = -750, AvailableCopies = 6, TotalCopies = 8, CategoryId = 8 },
            new Book { Id = 56, Title = "The Art of War", Author = "Sun Tzu", Description = "An ancient Chinese treatise on military strategy and tactics.", PublicationYear = -500, AvailableCopies = 7, TotalCopies = 10, CategoryId = 9 },
            new Book { Id = 57, Title = "The Prince", Author = "Niccolò Machiavelli", Description = "A political treatise about power and leadership, offering advice to rulers.", PublicationYear = 1532, AvailableCopies = 6, TotalCopies = 8, CategoryId = 9 },
            new Book { Id = 58, Title = "The 48 Laws of Power", Author = "Robert Greene", Description = "A guide to gaining and maintaining power, based on historical examples.", PublicationYear = 1998, AvailableCopies = 8, TotalCopies = 10, CategoryId = 10 },
            new Book { Id = 59, Title = "How to Win Friends and Influence People", Author = "Dale Carnegie", Description = "A timeless self-help book on building relationships and influencing others.", PublicationYear = 1936, AvailableCopies = 9, TotalCopies = 12, CategoryId = 10 },
            new Book { Id = 60, Title = "The Lean Startup", Author = "Eric Ries", Description = "A guide for entrepreneurs on how to create successful startups by using lean principles.", PublicationYear = 2011, AvailableCopies = 6, TotalCopies = 8, CategoryId = 10 },
            new Book { Id = 61, Title = "The Subtle Art of Not Giving a F*ck", Author = "Mark Manson", Description = "A self-help book that teaches readers to focus on what really matters in life.", PublicationYear = 2016, AvailableCopies = 7, TotalCopies = 10, CategoryId = 10 },
            new Book { Id = 62, Title = "Man's Search for Meaning", Author = "Viktor Frankl", Description = "A psychiatrist's account of his experiences in Nazi concentration camps and his exploration of finding meaning in life.", PublicationYear = 1946, AvailableCopies = 8, TotalCopies = 12, CategoryId = 10 },
            new Book { Id = 63, Title = "The History of Art", Author = "H. W. Janson", Description = "A comprehensive history of art from ancient times to the modern era.", PublicationYear = 1962, AvailableCopies = 6, TotalCopies = 8, CategoryId = 11 },
            new Book { Id = 64, Title = "The Painter's Secret Geometry", Author = "R. Buckminster Fuller", Description = "A book that explores the geometrical principles behind art, design, and architecture.", PublicationYear = 1975, AvailableCopies = 5, TotalCopies = 7, CategoryId = 11 },
            new Book { Id = 65, Title = "The Artist's Way", Author = "Julia Cameron", Description = "A guide to creative recovery and artistic self-expression.", PublicationYear = 1992, AvailableCopies = 6, TotalCopies = 8, CategoryId = 11 },
            new Book { Id = 66, Title = "The Birth of Tragedy", Author = "Friedrich Nietzsche", Description = "A philosophical work exploring the nature of Greek tragedy and the dichotomy between Apollonian and Dionysian forces.", PublicationYear = 1872, AvailableCopies = 7, TotalCopies = 10, CategoryId = 8 },
            new Book { Id = 67, Title = "The Sound of Music", Author = "Howard Lindsay", Description = "A musical that tells the story of the von Trapp family and their escape from Nazi Austria.", PublicationYear = 1959, AvailableCopies = 5, TotalCopies = 7, CategoryId = 12 },
            new Book { Id = 68, Title = "Beethoven's Letters", Author = "Ludwig van Beethoven", Description = "A collection of letters written by Beethoven, offering insights into his life and work.", PublicationYear = 1985, AvailableCopies = 6, TotalCopies = 8, CategoryId = 12 },
            new Book { Id = 69, Title = "The Musician's Way", Author = "Gerald Klickstein", Description = "A guide to practicing, performing, and maintaining a successful musical career.", PublicationYear = 2009, AvailableCopies = 7, TotalCopies = 10, CategoryId = 12 },
            new Book { Id = 70, Title = "The Healing Power of Music", Author = "Kristin McClellan", Description = "A book that explores the therapeutic benefits of music and its use in healing.", PublicationYear = 2016, AvailableCopies = 5, TotalCopies = 8, CategoryId = 12 },
            new Book { Id = 71, Title = "Born to Run", Author = "Christopher McDougall", Description = "A fascinating look at the world of ultramarathon running.", PublicationYear = 2009, AvailableCopies = 6, TotalCopies = 8, CategoryId = 13 },
            new Book { Id = 72, Title = "The Running Revolution", Author = "Nicholas Romanov", Description = "A book on the science of running, focusing on proper technique to avoid injury.", PublicationYear = 2012, AvailableCopies = 7, TotalCopies = 10, CategoryId = 13 },
            new Book { Id = 73, Title = "The Sports Gene", Author = "David Epstein", Description = "An exploration of the genetic and environmental factors that contribute to athletic success.", PublicationYear = 2013, AvailableCopies = 5, TotalCopies = 7, CategoryId = 13 },
            new Book { Id = 74, Title = "The War of Art", Author = "Steven Pressfield", Description = "A guide to overcoming creative resistance and achieving artistic success.", PublicationYear = 2002, AvailableCopies = 6, TotalCopies = 8, CategoryId = 14 },
            new Book { Id = 75, Title = "Cooked", Author = "Michael Pollan", Description = "A book about cooking, exploring the science and art of food preparation.", PublicationYear = 2013, AvailableCopies = 7, TotalCopies = 10, CategoryId = 14 },
            new Book { Id = 76, Title = "The Science of Cooking", Author = "Peter Barham", Description = "A book that explains the scientific principles behind cooking techniques.", PublicationYear = 2001, AvailableCopies = 6, TotalCopies = 8, CategoryId = 14 },
            new Book { Id = 77, Title = "The Joy of Baking", Author = "Sarah Kieffer", Description = "A baking book filled with delicious recipes and baking tips.", PublicationYear = 2017, AvailableCopies = 8, TotalCopies = 10, CategoryId = 14 },
            new Book { Id = 78, Title = "Into Thin Air", Author = "Jon Krakauer", Description = "A personal account of a disastrous expedition to Mount Everest.", PublicationYear = 1997, AvailableCopies = 9, TotalCopies = 12, CategoryId = 15 },
            new Book { Id = 79, Title = "In Patagonia", Author = "Bruce Chatwin", Description = "A travelogue about the author's journey through the wild and remote region of Patagonia.", PublicationYear = 1977, AvailableCopies = 6, TotalCopies = 8, CategoryId = 15 },
            new Book { Id = 80, Title = "A Walk in the Woods", Author = "Bill Bryson", Description = "A humorous account of the author's attempt to hike the Appalachian Trail.", PublicationYear = 1998, AvailableCopies = 7, TotalCopies = 10, CategoryId = 15 },
            new Book { Id = 81, Title = "The Secret Garden", Author = "Frances Hodgson Burnett", Description = "A beloved children's novel about a young girl who discovers a magical garden.", PublicationYear = 1911, AvailableCopies = 8, TotalCopies = 10, CategoryId = 16 },
            new Book { Id = 82, Title = "Alice's Adventures in Wonderland", Author = "Lewis Carroll", Description = "A whimsical story of a young girl who falls into a fantastical world.", PublicationYear = 1865, AvailableCopies = 5, TotalCopies = 7, CategoryId = 16 },
            new Book { Id = 83, Title = "The Lion, the Witch and the Wardrobe", Author = "C.S. Lewis", Description = "The first book in The Chronicles of Narnia series, where four siblings enter a magical world through a wardrobe.", PublicationYear = 1950, AvailableCopies = 6, TotalCopies = 8, CategoryId = 16 },
            new Book { Id = 84, Title = "The Wind in the Willows", Author = "Kenneth Grahame", Description = "A children's novel about the adventures of Mole, Rat, Badger, and Toad in the English countryside.", PublicationYear = 1908, AvailableCopies = 7, TotalCopies = 10, CategoryId = 16 },
            new Book { Id = 85, Title = "Charlotte's Web", Author = "E.B. White", Description = "A touching story about a pig named Wilbur and his friendship with a spider named Charlotte.", PublicationYear = 1952, AvailableCopies = 9, TotalCopies = 12, CategoryId = 16 },
            new Book { Id = 86, Title = "The Hobbit", Author = "J.R.R. Tolkien", Description = "The classic fantasy novel about the adventures of Bilbo Baggins.", PublicationYear = 1937, AvailableCopies = 10, TotalCopies = 12, CategoryId = 17 },
            new Book { Id = 87, Title = "The Fellowship of the Ring", Author = "J.R.R. Tolkien", Description = "The first book in The Lord of the Rings series, about the journey to destroy a powerful ring.", PublicationYear = 1954, AvailableCopies = 5, TotalCopies = 7, CategoryId = 17 },
            new Book { Id = 88, Title = "The Two Towers", Author = "J.R.R. Tolkien", Description = "The second book in The Lord of the Rings series, continuing the journey to destroy the One Ring.", PublicationYear = 1954, AvailableCopies = 6, TotalCopies = 8, CategoryId = 17 },
            new Book { Id = 89, Title = "The Return of the King", Author = "J.R.R. Tolkien", Description = "The final book in The Lord of the Rings series, concluding the epic quest to defeat Sauron.", PublicationYear = 1955, AvailableCopies = 7, TotalCopies = 10, CategoryId = 17 },
            new Book { Id = 90, Title = "The Hobbit: An Unexpected Journey", Author = "J.R.R. Tolkien", Description = "A prequel to The Lord of the Rings series, telling the story of Bilbo's adventure.", PublicationYear = 1937, AvailableCopies = 8, TotalCopies = 10, CategoryId = 17 },
            new Book { Id = 91, Title = "The Handmaid's Tale", Author = "Margaret Atwood", Description = "A dystopian novel set in a totalitarian society that controls women's rights and freedoms.", PublicationYear = 1985, AvailableCopies = 9, TotalCopies = 12, CategoryId = 22 },
            new Book { Id = 92, Title = "1984", Author = "George Orwell", Description = "A dystopian novel about a totalitarian regime where surveillance is constant and free thought is restricted.", PublicationYear = 1949, AvailableCopies = 6, TotalCopies = 8, CategoryId = 21 },
            new Book { Id = 93, Title = "Brave New World", Author = "Aldous Huxley", Description = "A vision of a future society where happiness is achieved through artificial means, and individualism is sacrificed.", PublicationYear = 1932, AvailableCopies = 8, TotalCopies = 10, CategoryId = 22 },
            new Book { Id = 94, Title = "The Hunger Games", Author = "Suzanne Collins", Description = "A dystopian novel set in a world where children are chosen to fight in a televised gladiatorial contest.", PublicationYear = 2008, AvailableCopies = 7, TotalCopies = 10, CategoryId = 22 },
            new Book { Id = 95, Title = "The Giver", Author = "Lois Lowry", Description = "A dystopian novel about a boy who begins to question the nature of his world after being chosen as the Receiver of Memory.", PublicationYear = 1993, AvailableCopies = 6, TotalCopies = 8, CategoryId = 22 },
            new Book { Id = 96, Title = "The Road", Author = "Cormac McCarthy", Description = "A post-apocalyptic novel about a father and son struggling to survive in a bleak, desolate world.", PublicationYear = 2006, AvailableCopies = 5, TotalCopies = 7, CategoryId = 22 },
            new Book { Id = 97, Title = "Fahrenheit 451", Author = "Ray Bradbury", Description = "A futuristic novel where books are banned, and firemen burn any that are found.", PublicationYear = 1953, AvailableCopies = 8, TotalCopies = 10, CategoryId = 21 },
            new Book { Id = 98, Title = "The Maze Runner", Author = "James Dashner", Description = "A dystopian novel about a group of teens trapped in a maze with no memory of how they got there.", PublicationYear = 2009, AvailableCopies = 7, TotalCopies = 10, CategoryId = 22 },
            new Book { Id = 99, Title = "Divergent", Author = "Veronica Roth", Description = "A young adult dystopian novel set in a society where people are divided into factions based on their virtues.", PublicationYear = 2011, AvailableCopies = 6, TotalCopies = 8, CategoryId = 22 },
            new Book { Id = 100, Title = "The City of Ember", Author = "Jeanne DuPrau", Description = "A post-apocalyptic novel about a city running out of power and the young people trying to escape.", PublicationYear = 2003, AvailableCopies = 7, TotalCopies = 10, CategoryId = 22 }
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
