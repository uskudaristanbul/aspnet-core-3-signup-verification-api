using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class PostCodeDistance
    {
        [Key]
        [Column("Item_id")]
        public int ItemId { get; set; }
        [Column("PostCode_id")]
        public int PostCodeId { get; set; }
        [Column("SecondPostCode_id")]
        public int SecondPostCodeId { get; set; }
        [Column(TypeName = "decimal(14, 4)")]
        public decimal? Distance { get; set; }

        [ForeignKey(nameof(PostCodeId))]
        [InverseProperty(nameof(Postcode.PostCodeDistancePostCode))]
        public virtual Postcode PostCode { get; set; }
        [ForeignKey(nameof(SecondPostCodeId))]
        [InverseProperty(nameof(Postcode.PostCodeDistanceSecondPostCode))]
        public virtual Postcode SecondPostCode { get; set; }
    }
}
