using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Store", Schema = "sales")]
    public partial class Store
    {
        public Store()
        {
            CartItem = new HashSet<CartItem>();
            Comment = new HashSet<Comment>();
            Contact = new HashSet<Contact>();
            FavoredProduct = new HashSet<FavoredProduct>();
            FavoredStore = new HashSet<FavoredStore>();
            FilterStoreStore = new HashSet<FilterStoreStore>();
            Location = new HashSet<Location>();
            Order = new HashSet<Order>();
            PostcodeStores = new HashSet<PostcodeStores>();
            ProductsStores = new HashSet<ProductsStores>();
            PurchaseItem = new HashSet<PurchaseItem>();
            Staff = new HashSet<Staff>();
            Stock = new HashSet<Stock>();
            Supplier = new HashSet<Supplier>();
        }

        [Key]
        [Column("store_id")]
        public int StoreId { get; set; }
        [Required]
        [Column("store_name")]
        [StringLength(255)]
        public string StoreName { get; set; }
        [Column("PostCode_id")]
        public int? PostCodeId { get; set; }
        [Column("Contact_id")]
        public int? ContactId { get; set; }
        [Column("StoreCategory_id")]
        public int? StoreCategoryId { get; set; }
        public int? WarehouseType { get; set; }
        [Column("Country_id")]
        public int? CountryId { get; set; }
        [Column("City_id")]
        public int? CityId { get; set; }
        [Column("Brand_id")]
        public int? BrandId { get; set; }
        public string LogoLink { get; set; }
        public string ThumbnailUrl { get; set; }
        public string PreviewUrl { get; set; }
        public string Slogan { get; set; }
        public string Description { get; set; }
        public string DeliveryDetails { get; set; }
        [StringLength(200)]
        public string Promotion { get; set; }
        [StringLength(200)]
        public string GeneralCatInfo { get; set; }
        public bool? IsHalal { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? HygieneRate { get; set; }
        [StringLength(50)]
        public string StoreBrand { get; set; }
        [StringLength(50)]
        public string StoreSize { get; set; }

        [ForeignKey(nameof(BrandId))]
        [InverseProperty(nameof(SellerBrand.Store))]
        public virtual SellerBrand Brand { get; set; }
        [ForeignKey(nameof(CityId))]
        [InverseProperty("Store")]
        public virtual City City { get; set; }
        [ForeignKey(nameof(CountryId))]
        [InverseProperty("Store")]
        public virtual Country Country { get; set; }
        [ForeignKey(nameof(PostCodeId))]
        [InverseProperty(nameof(Postcode.Store))]
        public virtual Postcode PostCode { get; set; }
        [ForeignKey(nameof(StoreCategoryId))]
        [InverseProperty("Store")]
        public virtual StoreCategory StoreCategory { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<CartItem> CartItem { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<Comment> Comment { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<Contact> Contact { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<FavoredProduct> FavoredProduct { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<FavoredStore> FavoredStore { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<FilterStoreStore> FilterStoreStore { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<Location> Location { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<Order> Order { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<PostcodeStores> PostcodeStores { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<ProductsStores> ProductsStores { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<PurchaseItem> PurchaseItem { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<Staff> Staff { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<Stock> Stock { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
