using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("FilterStore-Store", Schema = "tekyerco_kozmi")]
    public partial class FilterStoreStore
    {
        [Key]
        [Column("Store_id")]
        public int StoreId { get; set; }
        [Key]
        [Column("StoreFeature_id")]
        public int StoreFeatureId { get; set; }
        public bool? IsAvailable { get; set; }
        [Column(TypeName = "decimal(2, 2)")]
        public decimal? Rate { get; set; }

        [ForeignKey(nameof(StoreId))]
        [InverseProperty("FilterStoreStore")]
        public virtual Store Store { get; set; }
        [ForeignKey(nameof(StoreFeatureId))]
        [InverseProperty(nameof(FilterStore.FilterStoreStore))]
        public virtual FilterStore StoreFeature { get; set; }
    }
}
