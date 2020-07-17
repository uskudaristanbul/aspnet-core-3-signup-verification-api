using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("ShopGroup", Schema = "tekyerco_kozmi")]
    public partial class ShopGroup
    {
        [Key]
        [Column("ShopGroup_id")]
        public int ShopGroupId { get; set; }
        [Column("Customer_id")]
        public int? CustomerId { get; set; }
        [Column("Store_id")]
        public int? StoreId { get; set; }
        [Column("Category_id")]
        public int? CategoryId { get; set; }
    }
}
