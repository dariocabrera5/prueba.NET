using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace webApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public int Stock { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateRegistrer { get; set; }
    }
}