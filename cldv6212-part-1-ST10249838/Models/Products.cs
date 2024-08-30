using Azure;
using Azure.Data.Tables;
using Part1.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Part1.Models
{
    // This class is used to create the Orders table in the Azure Table Storage
    public class Products : ITableEntity
    {
        // ITableEntity
        public string? PartitionKey { get; set; }
        public string? RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; } = ETag.All;

        [Key]
        public string? ProductID { get; set; }

        [Required, MinLength(2, ErrorMessage = "Invalid Name")]
        public string? Name { get; set; }

        [Required, MinLength(10, ErrorMessage = "Description Too Short")]
        public string? Description { get; set; }

        [Required, Range(0.0, double.MaxValue, ErrorMessage = "Invalid Price")]
        public double Price { get; set; }

        [DataType(DataType.ImageUrl), AllowedExtensions(new[] { ".jpg", ".png" })]
        public string? ImageUrl { get; set; }
    }
}
