using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Layout_LayoutItem", Schema = "tekyerco_kozmi")]
    public partial class LayoutLayoutItem
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("Layout_id")]
        public int LayoutId { get; set; }
        [Column("LayoutItem_id")]
        public int LayoutItemId { get; set; }
    }
}
