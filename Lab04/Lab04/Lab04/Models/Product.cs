namespace Lab04.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [StringLength(20)]
        public string ProductID { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(20)]
        public string Unit { get; set; }

        public decimal? BuyPrice { get; set; }

        public decimal? SellPrice { get; set; }
    }
}
