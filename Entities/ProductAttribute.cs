using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Attribute", Schema = "tekyerco_kozmi")]
    public partial class ProductAttribute
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string AttributeName { get; set; }
        public int? Type { get; set; }
    }
}
