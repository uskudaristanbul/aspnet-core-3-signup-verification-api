using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Postcode", Schema = "dbo")]
    public partial class Postcode
    {
        public Postcode()
        {
            Address = new HashSet<Address>();
            Career = new HashSet<Career>();
            Location = new HashSet<Location>();
            PostCodeDistancePostCode = new HashSet<PostCodeDistance>();
            PostCodeDistanceSecondPostCode = new HashSet<PostCodeDistance>();
            PostcodeStores = new HashSet<PostcodeStores>();
            Store = new HashSet<Store>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(20)]
        public string PostcodeText { get; set; }
        [StringLength(50)]
        public string Latitute { get; set; }
        [StringLength(50)]
        public string Longitute { get; set; }
        public int? LondonZone { get; set; }
        [Column("AreaCode_id")]
        public int? AreaCodeId { get; set; }
        [Column("Location_id")]
        public int? LocationId { get; set; }
        [Column("Sector_id")]
        public int? SectorId { get; set; }
        [Column("PostCodeDistrict_id")]
        public int? PostCodeDistrictId { get; set; }
        public int? ServiceLevel { get; set; }

        [ForeignKey(nameof(AreaCodeId))]
        [InverseProperty("Postcode")]
        public virtual AreaCode AreaCode { get; set; }
        [ForeignKey(nameof(LocationId))]
        [InverseProperty("PostcodeNavigation")]
        public virtual Location LocationNavigation { get; set; }
        [ForeignKey(nameof(PostCodeDistrictId))]
        [InverseProperty("Postcode")]
        public virtual PostCodeDistrict PostCodeDistrict { get; set; }
        [ForeignKey(nameof(SectorId))]
        [InverseProperty(nameof(PostCodeSector.Postcode))]
        public virtual PostCodeSector Sector { get; set; }
        [InverseProperty("PostCode")]
        public virtual ICollection<Address> Address { get; set; }
        [InverseProperty("CareerPostCode")]
        public virtual ICollection<Career> Career { get; set; }
        [InverseProperty("Postcode")]
        public virtual ICollection<Location> Location { get; set; }
        [InverseProperty(nameof(PostCodeDistance.PostCode))]
        public virtual ICollection<PostCodeDistance> PostCodeDistancePostCode { get; set; }
        [InverseProperty(nameof(PostCodeDistance.SecondPostCode))]
        public virtual ICollection<PostCodeDistance> PostCodeDistanceSecondPostCode { get; set; }
        [InverseProperty("PostCode")]
        public virtual ICollection<PostcodeStores> PostcodeStores { get; set; }
        [InverseProperty("PostCode")]
        public virtual ICollection<Store> Store { get; set; }
    }
}
