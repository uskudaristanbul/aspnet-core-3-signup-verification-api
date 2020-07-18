using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("ShopGroup-Product", Schema = "tekyerco_kozmi")]
    public partial class ShopGroupProduct
    {
        [Key]
        [Column("Item_id")]
        public int ItemId { get; set; }
        [Column("ShopGroup_id")]
        public int? ShopGroupId { get; set; }
        [Column("Product_id")]
        public int? ProductId { get; set; }
    }
}
