using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("LayoutItem", Schema = "tekyerco_kozmi")]
    public partial class LayoutItem
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Page { get; set; }
        [StringLength(50)]
        public string Position { get; set; }
        [StringLength(500)]
        public string Title { get; set; }
        public string Description { get; set; }
        [StringLength(500)]
        public string Link { get; set; }
        public string ImageUrl { get; set; }
        public string Image2Url { get; set; }
        public string Image3Url { get; set; }
    }
}
