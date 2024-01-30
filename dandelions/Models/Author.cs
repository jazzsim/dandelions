using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dandelions.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string BookId { get; set; }
        public string Name { get; set; }

        public Author() { }

        public Author(int id, string bookId, string name)
        {
            Id = id;
            BookId = bookId;
            Name = name;
        }
    }
}
