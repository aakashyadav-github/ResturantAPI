using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResturantAPI.Models
{
    public class Item
    {   
        [Key]
        public Guid ItemId { get; set; }

        [Required]
        [MaxLength(100)]
        public string ItemName { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool Restricted { get; set; }

        [Required]
        public int MaxQuantity { get; set; }

        [Required]
        [MaxLength(200)]
        public string Photo { get; set; }

        [MaxLength(20)]
        public string Cat { get; set; }

        [MaxLength(20)]
        public string SubCat { get; set; }
    }
}
