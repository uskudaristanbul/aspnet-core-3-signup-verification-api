using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class PostcodeAvailableDate
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(10)]
        public string Postcode { get; set; }
        [Column(TypeName = "date")]
        public DateTime? AvailableDeliveryDate { get; set; }
        public bool? DoesServiceProvide { get; set; }
        public int? ServiceLevel { get; set; }
    }
}
