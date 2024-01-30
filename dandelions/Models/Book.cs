using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dandelions.Models
{
    public class Book
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        [Display(Name = "Binding Description")]
        public string BindingDescription { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal DiscountPrice { get; set; }
        [Display(Name = "Published Date")]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
        public int? Quantity { get; set; }
        public string? Status { get; set; }
        public string PostedBy { get; set; }

        public Book() { }

        public Book(int id, DateTime? createdAt, DateTime? updatedAt, string imageUrl, string title, string iSBN, string genre, string language, string bindingDescription, string description, int pages, decimal price, decimal discountPrice, DateTime publicationDate, int? quantity, string? status, string postedBy)
        {
            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ImageUrl = imageUrl;
            Title = title;
            ISBN = iSBN;
            Genre = genre;
            Language = language;
            BindingDescription = bindingDescription;
            Description = description;
            Pages = pages;
            Price = price;
            DiscountPrice = discountPrice;
            PublicationDate = publicationDate;
            Quantity = quantity;
            Status = status;
            PostedBy = postedBy;
        }
    }
}
