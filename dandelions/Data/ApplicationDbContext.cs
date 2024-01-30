using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using dandelions.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;
using dandelions.Controllers;

namespace dandelions.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<dandelions.Models.Book> Book { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>()
                .Property(b => b.CreatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Book>()
                .Property(b => b.UpdatedAt)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Book>()
                .Property(b => b.Quantity)
                .HasDefaultValue(1);

            modelBuilder.Entity<Book>()
                .Property(b => b.Status)
                .HasDefaultValue("Available");

            // Seed Genre
            modelBuilder.Entity<Genre>().HasData(
                new { Id = 1, Name = "Young Adult Fiction" },
                new { Id = 2, Name = "Comics & Graphic Novels" },
                new { Id = 3, Name = "Self-Help" },
                new { Id = 4, Name = "Biography & Autobiography" });


            // Seed Author
            modelBuilder.Entity<Author>().HasData(SeedAuthorData());

            // Seed User
            var users = SeedUser();
            modelBuilder.Entity<IdentityUser>().HasData(users);

            // Seed Book
            var books = SeedBookData();

            // Update postedBy to user uuid before saving to database
            updatePostedBy(books, users);

            modelBuilder.Entity<Book>().HasData(books);
        }
        public List<IdentityUser> SeedUser()
        {
            var users = new List<IdentityUser>();

            for (int i = 0; i < 30; i++)
            {
                var email = randomEmail();
                var user = new IdentityUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = email,
                    NormalizedUserName = email.ToUpper(),
                    Email = email,
                    NormalizedEmail = email.ToUpper(),
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                };

                var password = new PasswordHasher<IdentityUser>();
                var hashed = password.HashPassword(user, "Password123@");
                user.PasswordHash = hashed;

                users.Add(user);
            }
            return users;
        }
        public List<Book> SeedBookData()
        {
            var books = new List<Book>();
            using (StreamReader r = new StreamReader(@"Seeds/books/young-adult-fiction.json"))
            {
                string json = r.ReadToEnd();
                books = JsonConvert.DeserializeObject<List<Book>>(json) ?? [];
            }
            using (StreamReader r = new StreamReader(@"Seeds/books/comics.json"))
            {
                string json = r.ReadToEnd();
                books.AddRange(JsonConvert.DeserializeObject<List<Book>>(json) ?? []);
            }
            using (StreamReader r = new StreamReader(@"Seeds/books/self-help.json"))
            {
                string json = r.ReadToEnd();
                books.AddRange(JsonConvert.DeserializeObject<List<Book>>(json) ?? []);
            }
            using (StreamReader r = new StreamReader(@"Seeds/books/biography.json"))
            {
                string json = r.ReadToEnd();
                books.AddRange(JsonConvert.DeserializeObject<List<Book>>(json) ?? []);
            }
            return books;
        }
        public List<Author> SeedAuthorData()
        {
            var authors = new List<Author>();
            using (StreamReader r = new StreamReader(@"Seeds/authors/yaf-authors.json"))
            {
                string json = r.ReadToEnd();
                authors = JsonConvert.DeserializeObject<List<Author>>(json) ?? [];
            }
            using (StreamReader r = new StreamReader(@"Seeds/authors/cgn-authors.json"))
            {
                string json = r.ReadToEnd();
                authors.AddRange(JsonConvert.DeserializeObject<List<Author>>(json) ?? []);
            }
            using (StreamReader r = new StreamReader(@"Seeds/authors/sh-authors.json"))
            {
                string json = r.ReadToEnd();
                authors.AddRange(JsonConvert.DeserializeObject<List<Author>>(json) ?? []);
            }
            using (StreamReader r = new StreamReader(@"Seeds/authors/ba-authors.json"))
            {
                string json = r.ReadToEnd();
                authors.AddRange(JsonConvert.DeserializeObject<List<Author>>(json) ?? []);
            }
            return authors;
        }

        public void updatePostedBy(List<Book> books, List<IdentityUser> users )
        {
            // update postedBy to user uuid
            for (int i = 0; i < books.Count(); i++)
            {
                Book book = books[i];
                int userIndex = int.Parse(book.PostedBy);
                book.PostedBy = users[userIndex - 1].Id;
            }

        }
        public string randomEmail()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            string email = finalString + "@gmail.com";
            return email;
        }
    }
}
