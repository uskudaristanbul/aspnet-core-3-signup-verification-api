using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApi.Entities;

namespace WebApi.Helpers
{
    public partial class DataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AreaCode> AreaCode { get; set; }
        public virtual DbSet<ProductAttributes> Attribute { get; set; }
        public virtual DbSet<Career> Career { get; set; }
        public virtual DbSet<CareerOrder> CareerOrder { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<CartItem> CartItem { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddress { get; set; }
        public virtual DbSet<DeliveryRegion> DeliveryRegion { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<FavoredProduct> FavoredProduct { get; set; }
        public virtual DbSet<FavoredStore> FavoredStore { get; set; }
        public virtual DbSet<FilterStore> FilterStore { get; set; }
        public virtual DbSet<FilterStoreStore> FilterStoreStore { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Layout> Layout { get; set; }
        public virtual DbSet<LayoutItem> LayoutItem { get; set; }
        public virtual DbSet<LayoutLayoutItem> LayoutLayoutItem { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<OrderSlots> OrderSlots { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PostCodeDistance> PostCodeDistance { get; set; }
        public virtual DbSet<PostCodeDistrict> PostCodeDistrict { get; set; }
        public virtual DbSet<PostCodeSector> PostCodeSector { get; set; }
        public virtual DbSet<Postcode> Postcode { get; set; }
        public virtual DbSet<PostcodeDeliveryDate> PostcodeDeliveryDate { get; set; }
        public virtual DbSet<PostcodeStores> PostcodeStores { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductAlternateProduct> ProductAlternateProduct { get; set; }
        public virtual DbSet<ProductBrand> ProductBrand { get; set; }
        public virtual DbSet<ProductsStores> ProductsStores { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<PurchaseItem> PurchaseItem { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RegionStreet> RegionStreet { get; set; }
        public virtual DbSet<SellerBrand> SellerBrand { get; set; }
        public virtual DbSet<ShopGroup> ShopGroup { get; set; }
        public virtual DbSet<ShopGroupProduct> ShopGroupProduct { get; set; }
        public virtual DbSet<Slot> Slot { get; set; }
        public virtual DbSet<SlotPattern> SlotPattern { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreCategory> StoreCategory { get; set; }
        public virtual DbSet<Street> Street { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserShoppingCartProducts> UserShoppingCartProducts { get; set; }
        public virtual DbSet<Voucher> Voucher { get; set; }
        public virtual DbSet<WishList> WishList { get; set; }
        public virtual DbSet<WishlistItem> WishlistItem { get; set; }

        private readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    // connect to sqlite database
        //    options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=sql.zeus.domainhizmetleri.net;Database=tekyerco_DooryDB;User Id=tekyerco_doorydb; Password=Marmara1234");
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=DooryNewDB;Trusted_Connection=True;");
                //optionsBuilder.UseNpgsql("Host=km650864-001.dbaas.ovh.net ;Database=DBDoory;Username=mainUser;Password=Salih1234;Port=35446;Integrated Security=true;Pooling=true;");

            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "DBDoory");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_Address_Area");

                entity.HasOne(d => d.PostCode)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.PostCodeId)
                    .HasConstraintName("FK_Address_Postcodes");

                entity.HasOne(d => d.RegionNavigation)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.Region)
                    .HasConstraintName("FK_Address_DeliveryRegions");

                entity.HasOne(d => d.Street)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.StreetId)
                    .HasConstraintName("FK_Address_Streets");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Address_User");
            });

            modelBuilder.Entity<Career>(entity =>
            {
                entity.HasOne(d => d.CareerAddress)
                    .WithMany(p => p.Career)
                    .HasForeignKey(d => d.CareerAddressId)
                    .HasConstraintName("FK_Careers_Address");

                entity.HasOne(d => d.CareerCity)
                    .WithMany(p => p.Career)
                    .HasForeignKey(d => d.CareerCityId)
                    .HasConstraintName("FK_Careers_City");

                entity.HasOne(d => d.CareerDeliveryRegion)
                    .WithMany(p => p.Career)
                    .HasForeignKey(d => d.CareerDeliveryRegionId)
                    .HasConstraintName("FK_Careers_DeliveryRegions");

                entity.HasOne(d => d.CareerPostCode)
                    .WithMany(p => p.Career)
                    .HasForeignKey(d => d.CareerPostCodeId)
                    .HasConstraintName("FK_Careers_Postcodes");
            });

            modelBuilder.Entity<CareerOrder>(entity =>
            {
                entity.HasKey(e => new { e.CareerId, e.OrderId });

                entity.HasOne(d => d.Career)
                    .WithMany(p => p.CareerOrder)
                    .HasForeignKey(d => d.CareerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Career-Order_Career-Order");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.CareerOrder)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Career-Order_orders");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cart_customers");
            });

            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.Property(e => e.CartItemId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.CartItemNavigation)
                    .WithOne(p => p.CartItem)
                    .HasForeignKey<CartItem>(d => d.CartItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartItems_Cart");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CartItem)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_CartItems_products");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.CartItem)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_CartItems_Store");

                entity.HasOne(d => d.Voucher)
                    .WithMany(p => p.CartItem)
                    .HasForeignKey(d => d.VoucherId)
                    .HasConstraintName("FK_CartItems_Vouchers");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.StoreCategory)
                    .WithMany(p => p.Category)
                    .HasForeignKey(d => d.StoreCategoryId)
                    .HasConstraintName("FK_Category_StoreCategory");

                entity.HasOne(d => d.UpCategory)
                    .WithMany(p => p.InverseUpCategory)
                    .HasForeignKey(d => d.UpCategoryId)
                    .HasConstraintName("FK_categories_categories1");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Cities_Country");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Comment_Orders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Comment_Products");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_Comment_stores");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_Contacts_Address");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_Contacts_Stores");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);
            });

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.AddressId })
                    .HasName("PK_User-Address");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.CustomerAddress)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer-Address_Address");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddress)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer-Address_customers");
            });

            modelBuilder.Entity<DeliveryRegion>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .HasName("PK_Regions");
            });

            modelBuilder.Entity<FavoredProduct>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.CumstomerId })
                    .HasName("PK_FavoredProducts");

                entity.HasOne(d => d.Cumstomer)
                    .WithMany(p => p.FavoredProduct)
                    .HasForeignKey(d => d.CumstomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FavoredProducts_Customers");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.FavoredProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FavoredProducts_Products");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.FavoredProduct)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_FavoredProducts_Stores");
            });

            modelBuilder.Entity<FavoredStore>(entity =>
            {
                entity.HasKey(e => new { e.StoreId, e.CustomerId })
                    .HasName("PK_FavoredStores");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.FavoredStore)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_FavoredStores_Categories");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.FavoredStore)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FavoredStores_Customers");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.FavoredStore)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FavoredStores_Stores");
            });

            modelBuilder.Entity<FilterStoreStore>(entity =>
            {
                entity.HasKey(e => new { e.StoreId, e.StoreFeatureId })
                    .HasName("PK_Seller_SellerFeature");

                entity.HasOne(d => d.StoreFeature)
                    .WithMany(p => p.FilterStoreStore)
                    .HasForeignKey(d => d.StoreFeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Seller_SellerFeature_Seller_SellerFeature1");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.FilterStoreStore)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Seller_SellerFeature_Seller_SellerFeature");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasOne(d => d.Address)
                    .WithMany(p => p.LocationNavigation)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_Locations_Address");

                entity.HasOne(d => d.Career)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.CareerId)
                    .HasConstraintName("FK_Locations_Careers");

                entity.HasOne(d => d.Postcode)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.PostcodeId)
                    .HasConstraintName("FK_Locations_Postcodes");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_Locations_stores");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK__orders__staff_id__49C3F6B7");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__orders__store_id__48CFD27E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__orders__customer__47DBAE45");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK_order_items");

                entity.HasOne(d => d.AlternativeItem)
                    .WithMany(p => p.InverseAlternativeItem)
                    .HasForeignKey(d => d.AlternativeItemId)
                    .HasConstraintName("FK_order_items_order_items");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_OrderItems_Locations");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__order_items__order__4D94879B");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__order_ite__produ__4E88ABD4");
            });

            modelBuilder.Entity<OrderSlots>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.SlotId });

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderSlots)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Slots_Order");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.OrderSlots)
                    .HasForeignKey(d => d.SlotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Slots_SlotPattern");
            });

            modelBuilder.Entity<PostCodeDistance>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK_PostCodes-Distance_1");

                entity.HasOne(d => d.PostCode)
                    .WithMany(p => p.PostCodeDistancePostCode)
                    .HasForeignKey(d => d.PostCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostCodes-Distance_PostCodes-Distance");

                entity.HasOne(d => d.SecondPostCode)
                    .WithMany(p => p.PostCodeDistanceSecondPostCode)
                    .HasForeignKey(d => d.SecondPostCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostCodes-Distance_Postcodes");
            });

            modelBuilder.Entity<Postcode>(entity =>
            {
                entity.HasOne(d => d.AreaCode)
                    .WithMany(p => p.Postcode)
                    .HasForeignKey(d => d.AreaCodeId)
                    .HasConstraintName("FK_Postcode_AreaCode");

                entity.HasOne(d => d.LocationNavigation)
                    .WithMany(p => p.PostcodeNavigation)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_Postcodes_Locations");

                entity.HasOne(d => d.PostCodeDistrict)
                    .WithMany(p => p.Postcode)
                    .HasForeignKey(d => d.PostCodeDistrictId)
                    .HasConstraintName("FK_Postcodes_PostCodeDistricts");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.Postcode)
                    .HasForeignKey(d => d.SectorId)
                    .HasConstraintName("FK_Postcodes_PostCodeSectors");
            });

            modelBuilder.Entity<PostcodeDeliveryDate>(entity =>
            {
                entity.Property(e => e.Postcode).IsFixedLength();
            });

            modelBuilder.Entity<PostcodeStores>(entity =>
            {
                entity.HasKey(e => new { e.PostCodeId, e.StoreId })
                    .HasName("PK_Postcode_Stores_1");

                entity.HasOne(d => d.PostCode)
                    .WithMany(p => p.PostcodeStores)
                    .HasForeignKey(d => d.PostCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Postcode_Stores_Postcode");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PostcodeStores)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Postcode_Stores_Store");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductName).IsUnicode(false);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__products__brand___3C69FB99");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Product_SubCategory");
            });

            modelBuilder.Entity<ProductAlternateProduct>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.RelatedProductId })
                    .HasName("PK_Products-AlternativePorducts");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAlternateProductProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products-AlternativePorducts_products");

                entity.HasOne(d => d.RelatedProduct)
                    .WithMany(p => p.ProductAlternateProductRelatedProduct)
                    .HasForeignKey(d => d.RelatedProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products-AlternativePorducts_products1");
            });

            modelBuilder.Entity<ProductBrand>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("PK__Brands__5E5A8E2705218EA9");

                entity.Property(e => e.BrandName).IsUnicode(false);
            });

            modelBuilder.Entity<ProductsStores>(entity =>
            {
                entity.HasKey(e => new { e.StoreId, e.ProductId });

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductsStores)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products-Stores_Product");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.ProductsStores)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products-Stores_Store");
            });

            modelBuilder.Entity<PurchaseItem>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK_PurchaseItems_1");

                entity.HasOne(d => d.Career)
                    .WithMany(p => p.PurchaseItem)
                    .HasForeignKey(d => d.CareerId)
                    .HasConstraintName("FK_PurchaseItems_Careers");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.PurchaseItem)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_PurchaseItems_Locations");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PurchaseItem)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseItems_products");

                entity.HasOne(d => d.Purchase)
                    .WithMany(p => p.PurchaseItem)
                    .HasForeignKey(d => d.PurchaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseItems_Purchases");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.PurchaseItem)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_PurchaseItems_stores");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.AreaId)
                    .HasName("PK_Areas");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Region)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Areas_Cities");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Region)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Areas_Countries");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Region)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_Areas_Districts");
            });

            modelBuilder.Entity<RegionStreet>(entity =>
            {
                entity.HasKey(e => new { e.RegionId, e.StreetId })
                    .HasName("PK_Regions-Streets");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.RegionStreet)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Regions-Streets_DeliveryRegions");

                entity.HasOne(d => d.Street)
                    .WithMany(p => p.RegionStreet)
                    .HasForeignKey(d => d.StreetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Regions-Streets_Streets");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Staffs__AB6E61640B97E2B6")
                    .IsUnique();

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.InverseManager)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK__Staffs__manager___2739D489");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__staffs__store_id__440B1D61");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => new { e.StoreId, e.ProductId })
                    .HasName("PK__Stocks__E68284D31D1FFF5D");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__stocks__product___52593CB8");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__stocks__store_id__5165187F");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_Stores_Brands");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Stores_Cities");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Stores_Countries");

                entity.HasOne(d => d.PostCode)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.PostCodeId)
                    .HasConstraintName("FK_Stores_Postcodes");

                entity.HasOne(d => d.StoreCategory)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.StoreCategoryId)
                    .HasConstraintName("FK_Stores_Categories");
            });

            modelBuilder.Entity<StoreCategory>(entity =>
            {
                entity.HasOne(d => d.UpNavigation)
                    .WithMany(p => p.InverseUpNavigation)
                    .HasForeignKey(d => d.Up)
                    .HasConstraintName("FK_StoreCategories_StoreCategories1");
            });

            modelBuilder.Entity<Street>(entity =>
            {
                entity.HasOne(d => d.AreaNavigation)
                    .WithMany(p => p.Street)
                    .HasForeignKey(d => d.Area)
                    .HasConstraintName("FK_Streets_Areas");

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.Street)
                    .HasForeignKey(d => d.City)
                    .HasConstraintName("FK_Streets_City");

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.Street)
                    .HasForeignKey(d => d.Country)
                    .HasConstraintName("FK_Streets_Countries");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.PurchaseId)
                    .HasName("PK_Supplies");

                entity.HasOne(d => d.RelatedOrder)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.RelatedOrderId)
                    .HasConstraintName("FK_Supplies_orders");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_Supplies_stores");
            });

            modelBuilder.Entity<WishList>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.WishList)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_WishLists_Customers");
            });

            modelBuilder.Entity<WishlistItem>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK_WishlistItems");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WishlistItem)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_WishlistItems_Products");

                entity.HasOne(d => d.WishList)
                    .WithMany(p => p.WishlistItem)
                    .HasForeignKey(d => d.WishListId)
                    .HasConstraintName("FK_WishlistItems_WishLists");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}