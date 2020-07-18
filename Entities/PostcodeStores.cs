using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Postcode_Stores", Schema = "tekyerco_kozmi")]
    public partial class PostcodeStores
    {
        [Key]
        [Column("PostCode_id")]
        public int PostCodeId { get; set; }
        [Key]
        [Column("Store_id")]
        public int StoreId { get; set; }
        public int? DoesStoreDelivery { get; set; }
        public int? IsServiceActive { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Distance { get; set; }

        [ForeignKey(nameof(PostCodeId))]
        [InverseProperty(nameof(Postcode.PostcodeStores))]
        public virtual Postcode PostCode { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("PostcodeStores")]
        public virtual Store Store { get; set; }
    }
}
