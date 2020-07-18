using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class entitiesall2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "tekyerco_doory");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.EnsureSchema(
                name: "tekyerco_kozmi");

            migrationBuilder.EnsureSchema(
                name: "production");

            migrationBuilder.EnsureSchema(
                name: "sales");

            migrationBuilder.RenameTable(
                name: "RefreshToken",
                newName: "RefreshToken",
                newSchema: "tekyerco_doory");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "Accounts",
                newSchema: "tekyerco_doory");

            migrationBuilder.CreateTable(
                name: "Country",
                schema: "dbo",
                columns: table => new
                {
                    Country_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(maxLength: 50, nullable: true),
                    State_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Country_id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryRegion",
                schema: "dbo",
                columns: table => new
                {
                    Region_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionName = table.Column<string>(maxLength: 100, nullable: true),
                    RegionType = table.Column<int>(nullable: true),
                    UpdateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Region_id);
                });

            migrationBuilder.CreateTable(
                name: "District",
                schema: "dbo",
                columns: table => new
                {
                    District_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(maxLength: 100, nullable: true),
                    PostcodePart = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.District_id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                schema: "dbo",
                columns: table => new
                {
                    Image_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageLink = table.Column<string>(nullable: true),
                    ImageType = table.Column<int>(nullable: true),
                    ImageSize = table.Column<int>(nullable: true),
                    Product_id = table.Column<int>(nullable: true),
                    Category_id = table.Column<int>(nullable: true),
                    Comment_id = table.Column<int>(nullable: true),
                    MotherImage = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Image_id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                schema: "dbo",
                columns: table => new
                {
                    Payment_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentDescription = table.Column<string>(maxLength: 200, nullable: true),
                    TermStart = table.Column<DateTime>(type: "datetime", nullable: true),
                    TermEnd = table.Column<DateTime>(type: "datetime", nullable: true),
                    PaidTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Career_id = table.Column<int>(nullable: true),
                    Store_id = table.Column<int>(nullable: true),
                    Supply_id = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Payment_id);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                schema: "dbo",
                columns: table => new
                {
                    Purchase_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_id = table.Column<int>(nullable: true),
                    Store_id = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AmountPaid = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    AmountRemained = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.Purchase_id);
                });

            migrationBuilder.CreateTable(
                name: "Slot",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlotDate = table.Column<DateTime>(type: "date", nullable: true),
                    Btw_8_11Available = table.Column<bool>(nullable: true),
                    Btw_11_14Available = table.Column<bool>(nullable: true),
                    Btw_14_17Available = table.Column<bool>(nullable: true),
                    Btw_17_20Available = table.Column<bool>(nullable: true),
                    Btw_20_23Available = table.Column<bool>(nullable: true),
                    ExpressDelivery = table.Column<bool>(nullable: true),
                    Order_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slot", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                schema: "dbo",
                columns: table => new
                {
                    Voucher_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherDescription = table.Column<string>(maxLength: 200, nullable: true),
                    VoucherCode = table.Column<string>(maxLength: 50, nullable: true),
                    DiscountRate = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.Voucher_id);
                });

            migrationBuilder.CreateTable(
                name: "ProductBrand",
                schema: "production",
                columns: table => new
                {
                    brand_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brand_name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    Image_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Brands__5E5A8E2705218EA9", x => x.brand_id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "sales",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    last_name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    phone = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    PostCode = table.Column<int>(nullable: true),
                    RefreshToken = table.Column<string>(maxLength: 500, nullable: true),
                    RefreshTokenEndDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AreaCode",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaCodeText = table.Column<string>(maxLength: 10, nullable: true),
                    Country_id = table.Column<int>(nullable: true),
                    City_id = table.Column<int>(nullable: true),
                    District_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaCode", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Attribute",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeName = table.Column<string>(maxLength: 50, nullable: true),
                    Type = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attribute", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilterStore",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Descripton = table.Column<string>(maxLength: 1000, nullable: true),
                    Type = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilterStore", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Layout",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Region = table.Column<int>(nullable: true),
                    Country = table.Column<int>(nullable: true),
                    MainPage_TopMenuItems = table.Column<string>(maxLength: 700, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Layout", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Layout_LayoutItem",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Layout_id = table.Column<int>(nullable: false),
                    LayoutItem_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Layout_LayoutItem", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "LayoutItem",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: true),
                    Page = table.Column<string>(maxLength: 50, nullable: true),
                    Position = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 500, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Link = table.Column<string>(maxLength: 500, nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Image2Url = table.Column<string>(nullable: true),
                    Image3Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LayoutItem", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Postcode_DeliveryDate",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Postcode = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true),
                    AvailableDeliveryDate = table.Column<DateTime>(type: "date", nullable: true),
                    DoesServiceProvide = table.Column<bool>(nullable: true),
                    ServiceLevel = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postcode_DeliveryDate", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PostCodeDistrict",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostCodeDistrict = table.Column<string>(maxLength: 10, nullable: true),
                    PostCodeArea_id = table.Column<int>(nullable: true),
                    City_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCodeDistrict", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PostCodeSector",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostCodeSector = table.Column<string>(maxLength: 10, nullable: true),
                    PostCodeArea_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCodeSector", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SellerBrand",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(maxLength: 200, nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellerBrand", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ShopGroup",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    ShopGroup_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_id = table.Column<int>(nullable: true),
                    Store_id = table.Column<int>(nullable: true),
                    Category_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopGroup", x => x.ShopGroup_id);
                });

            migrationBuilder.CreateTable(
                name: "ShopGroup-Product",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    Item_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopGroup_id = table.Column<int>(nullable: true),
                    Product_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopGroup-Product", x => x.Item_id);
                });

            migrationBuilder.CreateTable(
                name: "SlotPattern",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<string>(maxLength: 50, nullable: true),
                    StartTime = table.Column<string>(maxLength: 50, nullable: true),
                    EndTime = table.Column<string>(maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    OpenTime = table.Column<TimeSpan>(nullable: true),
                    CloseTime = table.Column<TimeSpan>(nullable: true),
                    Store_id = table.Column<int>(nullable: true),
                    IsDefault = table.Column<bool>(nullable: true),
                    DeliveryPrice1km = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    DeliveryPrice2km = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    DeliveryPrice5km = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    DeliveryPrice10km = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    DeliveryPricePerkm = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    GeneralDefaultSlot = table.Column<bool>(nullable: true),
                    DescriptionNotAvailable = table.Column<string>(maxLength: 500, nullable: true),
                    IsAvailable = table.Column<bool>(nullable: true),
                    DescriptionLimitedAvailable = table.Column<string>(maxLength: 500, nullable: true),
                    GeneralDescription = table.Column<string>(maxLength: 500, nullable: true),
                    ExpressDeliveryIsAvailable = table.Column<bool>(nullable: true),
                    Btw_8_11Available = table.Column<bool>(nullable: true),
                    Btw_11_14Available = table.Column<bool>(nullable: true),
                    Btw_14_17Available = table.Column<bool>(nullable: true),
                    Btw_17_20Available = table.Column<bool>(nullable: true),
                    Btw_20_23Available = table.Column<bool>(nullable: true),
                    ServiceLevel = table.Column<int>(nullable: true),
                    ServiceLevelDeliveryFee = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    ServiceFeeForUnder = table.Column<decimal>(type: "decimal(12, 2)", nullable: true),
                    ExpressDeliveryFee = table.Column<decimal>(type: "decimal(12, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlotPattern", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "StoreCategory",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Up = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreCategories_StoreCategories1",
                        column: x => x.Up,
                        principalSchema: "tekyerco_kozmi",
                        principalTable: "StoreCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 100, nullable: true),
                    sirname = table.Column<string>(maxLength: 100, nullable: true),
                    email = table.Column<string>(maxLength: 100, nullable: true),
                    phone = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User_ShoppingCartProducts",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_id = table.Column<int>(nullable: true),
                    ListPrice = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    SalePrice = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    NumberOfPiece = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    AmountType = table.Column<string>(type: "text", nullable: true),
                    Coupon_id = table.Column<int>(nullable: true),
                    DiscountDescription = table.Column<string>(maxLength: 250, nullable: true),
                    User_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_ShoppingCartProducts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                schema: "dbo",
                columns: table => new
                {
                    City_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(maxLength: 100, nullable: true),
                    Country_id = table.Column<int>(nullable: true),
                    State_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.City_id);
                    table.ForeignKey(
                        name: "FK_Cities_Country",
                        column: x => x.Country_id,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Country_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                schema: "dbo",
                columns: table => new
                {
                    Cart_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_id = table.Column<int>(nullable: false),
                    Voucher_id = table.Column<int>(nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(10, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Cart_id);
                    table.ForeignKey(
                        name: "FK_Cart_customers",
                        column: x => x.Customer_id,
                        principalSchema: "sales",
                        principalTable: "Customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WishList",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    WishList_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_id = table.Column<int>(nullable: true),
                    AddTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishList", x => x.WishList_id);
                    table.ForeignKey(
                        name: "FK_WishLists_Customers",
                        column: x => x.Customer_id,
                        principalSchema: "sales",
                        principalTable: "Customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "production",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    UpCategory_id = table.Column<int>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    StoreCategory_id = table.Column<int>(nullable: true),
                    OrderNumber = table.Column<int>(nullable: true),
                    IsTopProductCategory = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_StoreCategory",
                        column: x => x.StoreCategory_id,
                        principalSchema: "tekyerco_kozmi",
                        principalTable: "StoreCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_categories_categories1",
                        column: x => x.UpCategory_id,
                        principalSchema: "production",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                schema: "dbo",
                columns: table => new
                {
                    Area_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaName = table.Column<string>(maxLength: 50, nullable: true),
                    District_id = table.Column<int>(nullable: true),
                    City_id = table.Column<int>(nullable: true),
                    Country_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Area_id);
                    table.ForeignKey(
                        name: "FK_Areas_Cities",
                        column: x => x.City_id,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "City_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Areas_Countries",
                        column: x => x.Country_id,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Country_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Areas_Districts",
                        column: x => x.District_id,
                        principalSchema: "dbo",
                        principalTable: "District",
                        principalColumn: "District_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "production",
                columns: table => new
                {
                    Product_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_name = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    ShortDescription = table.Column<string>(maxLength: 200, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SKU = table.Column<string>(maxLength: 50, nullable: true),
                    Barcode = table.Column<string>(nullable: true),
                    Brand_id = table.Column<int>(nullable: true),
                    MainImage = table.Column<string>(nullable: true),
                    Image2 = table.Column<string>(nullable: true),
                    Image3 = table.Column<string>(nullable: true),
                    Image4 = table.Column<string>(nullable: true),
                    Image5 = table.Column<string>(nullable: true),
                    MotherProduct_id = table.Column<int>(nullable: true),
                    Category_id = table.Column<int>(nullable: true),
                    NumberOfSold = table.Column<int>(nullable: true),
                    OrderNumber = table.Column<int>(nullable: true),
                    UnitType = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(10, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Product_id);
                    table.ForeignKey(
                        name: "FK__products__brand___3C69FB99",
                        column: x => x.Brand_id,
                        principalSchema: "production",
                        principalTable: "ProductBrand",
                        principalColumn: "brand_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_SubCategory",
                        column: x => x.Category_id,
                        principalSchema: "production",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Street",
                schema: "dbo",
                columns: table => new
                {
                    Street_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetName = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<int>(nullable: true),
                    Area = table.Column<int>(nullable: true),
                    Country = table.Column<int>(nullable: true),
                    Location = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Street", x => x.Street_id);
                    table.ForeignKey(
                        name: "FK_Streets_Areas",
                        column: x => x.Area,
                        principalSchema: "dbo",
                        principalTable: "Region",
                        principalColumn: "Area_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Streets_City",
                        column: x => x.City,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "City_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Streets_Countries",
                        column: x => x.Country,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Country_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product-AlternateProduct",
                schema: "dbo",
                columns: table => new
                {
                    Product_id = table.Column<int>(nullable: false),
                    RelatedProduct_id = table.Column<int>(nullable: false),
                    RelationType = table.Column<int>(nullable: true),
                    RelationPower = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products-AlternativePorducts", x => new { x.Product_id, x.RelatedProduct_id });
                    table.ForeignKey(
                        name: "FK_Products-AlternativePorducts_products",
                        column: x => x.Product_id,
                        principalSchema: "production",
                        principalTable: "Product",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products-AlternativePorducts_products1",
                        column: x => x.RelatedProduct_id,
                        principalSchema: "production",
                        principalTable: "Product",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WishlistItem",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    item_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_id = table.Column<int>(nullable: true),
                    WishList_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistItems", x => x.item_id);
                    table.ForeignKey(
                        name: "FK_WishlistItems_Products",
                        column: x => x.Product_id,
                        principalSchema: "production",
                        principalTable: "Product",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WishlistItems_WishLists",
                        column: x => x.WishList_id,
                        principalSchema: "tekyerco_kozmi",
                        principalTable: "WishList",
                        principalColumn: "WishList_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Region-Street",
                schema: "dbo",
                columns: table => new
                {
                    Region_id = table.Column<int>(nullable: false),
                    Street_id = table.Column<int>(nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions-Streets", x => new { x.Region_id, x.Street_id });
                    table.ForeignKey(
                        name: "FK_Regions-Streets_DeliveryRegions",
                        column: x => x.Region_id,
                        principalSchema: "dbo",
                        principalTable: "DeliveryRegion",
                        principalColumn: "Region_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Regions-Streets_Streets",
                        column: x => x.Street_id,
                        principalSchema: "dbo",
                        principalTable: "Street",
                        principalColumn: "Street_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Career",
                schema: "dbo",
                columns: table => new
                {
                    Career_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CareerName = table.Column<string>(maxLength: 200, nullable: true),
                    CareerPostCode_id = table.Column<int>(nullable: true),
                    CareerCity_id = table.Column<int>(nullable: true),
                    CareerAddress_id = table.Column<int>(nullable: true),
                    CareerDeliveryRegion_id = table.Column<int>(nullable: true),
                    Account_id = table.Column<int>(nullable: true),
                    CareerType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Career", x => x.Career_id);
                    table.ForeignKey(
                        name: "FK_Careers_City",
                        column: x => x.CareerCity_id,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "City_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Careers_DeliveryRegions",
                        column: x => x.CareerDeliveryRegion_id,
                        principalSchema: "dbo",
                        principalTable: "DeliveryRegion",
                        principalColumn: "Region_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer-Address",
                schema: "dbo",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    DateEntered = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User-Address", x => new { x.CustomerId, x.AddressId });
                    table.ForeignKey(
                        name: "FK_Customer-Address_customers",
                        column: x => x.CustomerId,
                        principalSchema: "sales",
                        principalTable: "Customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(maxLength: 100, nullable: true),
                    Store_id = table.Column<int>(nullable: true),
                    Career_id = table.Column<int>(nullable: true),
                    Car_id = table.Column<int>(nullable: true),
                    Address_id = table.Column<int>(nullable: true),
                    Postcode_id = table.Column<int>(nullable: true),
                    TypeOfLocation_id = table.Column<int>(nullable: true),
                    Street_id = table.Column<int>(nullable: true),
                    Country_id = table.Column<int>(nullable: true),
                    City_id = table.Column<int>(nullable: true),
                    Borough_id = table.Column<int>(nullable: true),
                    District_id = table.Column<int>(nullable: true),
                    Avenue_id = table.Column<int>(nullable: true),
                    Latitude = table.Column<string>(maxLength: 50, nullable: true),
                    Longitude = table.Column<string>(maxLength: 50, nullable: true),
                    Easting = table.Column<string>(maxLength: 50, nullable: true),
                    Northing = table.Column<string>(maxLength: 50, nullable: true),
                    AreaCode = table.Column<string>(maxLength: 6, nullable: true),
                    DistrictCode = table.Column<string>(maxLength: 6, nullable: true),
                    LondonZone = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Careers",
                        column: x => x.Career_id,
                        principalSchema: "dbo",
                        principalTable: "Career",
                        principalColumn: "Career_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Postcode",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostcodeText = table.Column<string>(maxLength: 20, nullable: true),
                    Latitute = table.Column<string>(maxLength: 50, nullable: true),
                    Longitute = table.Column<string>(maxLength: 50, nullable: true),
                    LondonZone = table.Column<int>(nullable: true),
                    AreaCode_id = table.Column<int>(nullable: true),
                    Location_id = table.Column<int>(nullable: true),
                    Sector_id = table.Column<int>(nullable: true),
                    PostCodeDistrict_id = table.Column<int>(nullable: true),
                    ServiceLevel = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postcode", x => x.id);
                    table.ForeignKey(
                        name: "FK_Postcode_AreaCode",
                        column: x => x.AreaCode_id,
                        principalSchema: "tekyerco_kozmi",
                        principalTable: "AreaCode",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Postcodes_Locations",
                        column: x => x.Location_id,
                        principalSchema: "dbo",
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Postcodes_PostCodeDistricts",
                        column: x => x.PostCodeDistrict_id,
                        principalSchema: "tekyerco_kozmi",
                        principalTable: "PostCodeDistrict",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Postcodes_PostCodeSectors",
                        column: x => x.Sector_id,
                        principalSchema: "tekyerco_kozmi",
                        principalTable: "PostCodeSector",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressName = table.Column<string>(maxLength: 50, nullable: true),
                    AddressType = table.Column<int>(nullable: true),
                    IsBilling = table.Column<bool>(nullable: true),
                    IsCompany = table.Column<bool>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Surname = table.Column<string>(maxLength: 50, nullable: true),
                    CompanyName = table.Column<string>(maxLength: 50, nullable: true),
                    CompanyNumber = table.Column<int>(nullable: true),
                    PostCode_id = table.Column<int>(nullable: true),
                    FlatNo = table.Column<string>(maxLength: 50, nullable: true),
                    BuildingName = table.Column<string>(maxLength: 50, nullable: true),
                    Street_id = table.Column<int>(nullable: true),
                    Area_id = table.Column<int>(nullable: true),
                    Region = table.Column<int>(nullable: true),
                    Phone = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    MobilePhone = table.Column<string>(maxLength: 50, nullable: true),
                    DescriptionToFind = table.Column<string>(maxLength: 200, nullable: true),
                    GatePassword = table.Column<string>(maxLength: 50, nullable: true),
                    ResponsibleName = table.Column<string>(maxLength: 50, nullable: true),
                    ResponsibleSurname = table.Column<string>(maxLength: 50, nullable: true),
                    ResponsiblePhone = table.Column<string>(maxLength: 50, nullable: true),
                    IsPrimary = table.Column<bool>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    Location = table.Column<string>(maxLength: 100, nullable: true),
                    User_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.id);
                    table.ForeignKey(
                        name: "FK_Address_Area",
                        column: x => x.Area_id,
                        principalSchema: "dbo",
                        principalTable: "Region",
                        principalColumn: "Area_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_Postcodes",
                        column: x => x.PostCode_id,
                        principalSchema: "dbo",
                        principalTable: "Postcode",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_DeliveryRegions",
                        column: x => x.Region,
                        principalSchema: "dbo",
                        principalTable: "DeliveryRegion",
                        principalColumn: "Region_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_Streets",
                        column: x => x.Street_id,
                        principalSchema: "dbo",
                        principalTable: "Street",
                        principalColumn: "Street_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_User",
                        column: x => x.User_id,
                        principalSchema: "tekyerco_kozmi",
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                schema: "sales",
                columns: table => new
                {
                    store_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    store_name = table.Column<string>(maxLength: 255, nullable: false),
                    PostCode_id = table.Column<int>(nullable: true),
                    Contact_id = table.Column<int>(nullable: true),
                    StoreCategory_id = table.Column<int>(nullable: true),
                    WarehouseType = table.Column<int>(nullable: true),
                    Country_id = table.Column<int>(nullable: true),
                    City_id = table.Column<int>(nullable: true),
                    Brand_id = table.Column<int>(nullable: true),
                    LogoLink = table.Column<string>(nullable: true),
                    ThumbnailUrl = table.Column<string>(nullable: true),
                    PreviewUrl = table.Column<string>(nullable: true),
                    Slogan = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DeliveryDetails = table.Column<string>(nullable: true),
                    Promotion = table.Column<string>(maxLength: 200, nullable: true),
                    GeneralCatInfo = table.Column<string>(maxLength: 200, nullable: true),
                    IsHalal = table.Column<bool>(nullable: true),
                    HygieneRate = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    StoreBrand = table.Column<string>(maxLength: 50, nullable: true),
                    StoreSize = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.store_id);
                    table.ForeignKey(
                        name: "FK_Stores_Brands",
                        column: x => x.Brand_id,
                        principalSchema: "tekyerco_kozmi",
                        principalTable: "SellerBrand",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stores_Cities",
                        column: x => x.City_id,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "City_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stores_Countries",
                        column: x => x.Country_id,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Country_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stores_Postcodes",
                        column: x => x.PostCode_id,
                        principalSchema: "dbo",
                        principalTable: "Postcode",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stores_Categories",
                        column: x => x.StoreCategory_id,
                        principalSchema: "tekyerco_kozmi",
                        principalTable: "StoreCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostCode-Distance",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    Item_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostCode_id = table.Column<int>(nullable: false),
                    SecondPostCode_id = table.Column<int>(nullable: false),
                    Distance = table.Column<decimal>(type: "decimal(14, 4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCodes-Distance_1", x => x.Item_id);
                    table.ForeignKey(
                        name: "FK_PostCodes-Distance_PostCodes-Distance",
                        column: x => x.PostCode_id,
                        principalSchema: "dbo",
                        principalTable: "Postcode",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostCodes-Distance_Postcodes",
                        column: x => x.SecondPostCode_id,
                        principalSchema: "dbo",
                        principalTable: "Postcode",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                schema: "dbo",
                columns: table => new
                {
                    CartItem_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cart_id = table.Column<int>(nullable: true),
                    Product_id = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    Store_id = table.Column<int>(nullable: true),
                    ListPrice = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    DiscountedPrice = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    SoldPrice = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    Voucher_id = table.Column<int>(nullable: true),
                    IsInSaveLater = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.CartItem_id);
                    table.ForeignKey(
                        name: "FK_CartItems_Cart",
                        column: x => x.CartItem_id,
                        principalSchema: "dbo",
                        principalTable: "Cart",
                        principalColumn: "Cart_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_products",
                        column: x => x.Product_id,
                        principalSchema: "production",
                        principalTable: "Product",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_Store",
                        column: x => x.Store_id,
                        principalSchema: "sales",
                        principalTable: "Store",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItems_Vouchers",
                        column: x => x.Voucher_id,
                        principalSchema: "dbo",
                        principalTable: "Voucher",
                        principalColumn: "Voucher_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseItem",
                schema: "dbo",
                columns: table => new
                {
                    Item_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Purchase_id = table.Column<int>(nullable: false),
                    Product_id = table.Column<int>(nullable: false),
                    PurchaseStatus = table.Column<int>(nullable: true),
                    Store_id = table.Column<int>(nullable: true),
                    Career_id = table.Column<int>(nullable: true),
                    ItemBarcode = table.Column<string>(maxLength: 50, nullable: true),
                    ProcessPhase = table.Column<int>(nullable: true),
                    Location_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseItems_1", x => x.Item_id);
                    table.ForeignKey(
                        name: "FK_PurchaseItems_Careers",
                        column: x => x.Career_id,
                        principalSchema: "dbo",
                        principalTable: "Career",
                        principalColumn: "Career_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseItems_Locations",
                        column: x => x.Location_id,
                        principalSchema: "dbo",
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseItems_products",
                        column: x => x.Product_id,
                        principalSchema: "production",
                        principalTable: "Product",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseItems_Purchases",
                        column: x => x.Purchase_id,
                        principalSchema: "dbo",
                        principalTable: "Purchase",
                        principalColumn: "Purchase_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseItems_stores",
                        column: x => x.Store_id,
                        principalSchema: "sales",
                        principalTable: "Store",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                schema: "production",
                columns: table => new
                {
                    store_id = table.Column<int>(nullable: false),
                    product_id = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: true),
                    StoreWholePrice = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    StoreSalePrice = table.Column<decimal>(type: "decimal(10, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Stocks__E68284D31D1FFF5D", x => new { x.store_id, x.product_id });
                    table.ForeignKey(
                        name: "FK__stocks__product___52593CB8",
                        column: x => x.product_id,
                        principalSchema: "production",
                        principalTable: "Product",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__stocks__store_id__5165187F",
                        column: x => x.store_id,
                        principalSchema: "sales",
                        principalTable: "Store",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                schema: "sales",
                columns: table => new
                {
                    staff_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    last_name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    email = table.Column<string>(unicode: false, maxLength: 255, nullable: false),
                    phone = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    active = table.Column<byte>(nullable: false),
                    store_id = table.Column<int>(nullable: false),
                    manager_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.staff_id);
                    table.ForeignKey(
                        name: "FK__Staffs__manager___2739D489",
                        column: x => x.manager_id,
                        principalSchema: "sales",
                        principalTable: "Staff",
                        principalColumn: "staff_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__staffs__store_id__440B1D61",
                        column: x => x.store_id,
                        principalSchema: "sales",
                        principalTable: "Store",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactOwnerType = table.Column<string>(maxLength: 50, nullable: true),
                    Store_id = table.Column<int>(nullable: true),
                    Phone = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Address_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.id);
                    table.ForeignKey(
                        name: "FK_Contacts_Address",
                        column: x => x.Address_id,
                        principalSchema: "dbo",
                        principalTable: "Address",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_Stores",
                        column: x => x.Store_id,
                        principalSchema: "sales",
                        principalTable: "Store",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FavoredProduct",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    Product_id = table.Column<int>(nullable: false),
                    Cumstomer_id = table.Column<int>(nullable: false),
                    Store_id = table.Column<int>(nullable: true),
                    IsLiked = table.Column<bool>(nullable: true),
                    PurchasedNumber = table.Column<int>(nullable: true),
                    CanceledNumber = table.Column<int>(nullable: true),
                    ReturnedNumber = table.Column<int>(nullable: true),
                    AlternativePurchasedProduct_id = table.Column<int>(nullable: true),
                    SecondAlternativePurchasedProduct_id = table.Column<int>(nullable: true),
                    ThirdAlternativePurchasedProduct_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoredProducts", x => new { x.Product_id, x.Cumstomer_id });
                    table.ForeignKey(
                        name: "FK_FavoredProducts_Customers",
                        column: x => x.Cumstomer_id,
                        principalSchema: "sales",
                        principalTable: "Customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FavoredProducts_Products",
                        column: x => x.Product_id,
                        principalSchema: "production",
                        principalTable: "Product",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FavoredProducts_Stores",
                        column: x => x.Store_id,
                        principalSchema: "sales",
                        principalTable: "Store",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FavoredStore",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    Store_id = table.Column<int>(nullable: false),
                    Customer_id = table.Column<int>(nullable: false),
                    IsFavored = table.Column<bool>(nullable: true),
                    Category_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoredStores", x => new { x.Store_id, x.Customer_id });
                    table.ForeignKey(
                        name: "FK_FavoredStores_Categories",
                        column: x => x.Category_id,
                        principalSchema: "production",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FavoredStores_Customers",
                        column: x => x.Customer_id,
                        principalSchema: "sales",
                        principalTable: "Customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FavoredStores_Stores",
                        column: x => x.Store_id,
                        principalSchema: "sales",
                        principalTable: "Store",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilterStore-Store",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    Store_id = table.Column<int>(nullable: false),
                    StoreFeature_id = table.Column<int>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: true),
                    Rate = table.Column<decimal>(type: "decimal(2, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seller_SellerFeature", x => new { x.Store_id, x.StoreFeature_id });
                    table.ForeignKey(
                        name: "FK_Seller_SellerFeature_Seller_SellerFeature1",
                        column: x => x.StoreFeature_id,
                        principalSchema: "tekyerco_kozmi",
                        principalTable: "FilterStore",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Seller_SellerFeature_Seller_SellerFeature",
                        column: x => x.Store_id,
                        principalSchema: "sales",
                        principalTable: "Store",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Postcode_Stores",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    PostCode_id = table.Column<int>(nullable: false),
                    Store_id = table.Column<int>(nullable: false),
                    DoesStoreDelivery = table.Column<int>(nullable: true),
                    IsServiceActive = table.Column<int>(nullable: true),
                    Distance = table.Column<decimal>(type: "decimal(10, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postcode_Stores_1", x => new { x.PostCode_id, x.Store_id });
                    table.ForeignKey(
                        name: "FK_Postcode_Stores_Postcode",
                        column: x => x.PostCode_id,
                        principalSchema: "dbo",
                        principalTable: "Postcode",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Postcode_Stores_Store",
                        column: x => x.Store_id,
                        principalSchema: "sales",
                        principalTable: "Store",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products-Stores",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    Store_id = table.Column<int>(nullable: false),
                    Product_id = table.Column<int>(nullable: false),
                    SKU = table.Column<string>(maxLength: 50, nullable: true),
                    StockAmount = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    StockAmountType = table.Column<string>(maxLength: 10, nullable: true),
                    StorePrice = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    StoreDiscountedPrice = table.Column<decimal>(type: "decimal(10, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products-Stores", x => new { x.Store_id, x.Product_id });
                    table.ForeignKey(
                        name: "FK_Products-Stores_Product",
                        column: x => x.Product_id,
                        principalSchema: "production",
                        principalTable: "Product",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products-Stores_Store",
                        column: x => x.Store_id,
                        principalSchema: "sales",
                        principalTable: "Store",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                schema: "sales",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(nullable: false),
                    address_id = table.Column<int>(nullable: true),
                    Slot_id = table.Column<int>(nullable: true),
                    order_status = table.Column<int>(nullable: true),
                    order_date = table.Column<DateTime>(type: "date", nullable: true),
                    required_date = table.Column<DateTime>(type: "date", nullable: true),
                    shipped_date = table.Column<DateTime>(type: "date", nullable: true),
                    store_id = table.Column<int>(nullable: true),
                    staff_id = table.Column<int>(nullable: true),
                    SignImageLink = table.Column<string>(nullable: true),
                    DeliveryTotalCost = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    DeliveryFeeTaken = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    FirstTimeVisited = table.Column<DateTime>(type: "datetime", nullable: true),
                    SecondTimeVisited = table.Column<DateTime>(type: "datetime", nullable: true),
                    FirstVisitResult = table.Column<int>(nullable: true),
                    SecondVisitResult = table.Column<int>(nullable: true),
                    DeliveryCareerCost = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    OrderType = table.Column<int>(nullable: true),
                    VisitResultDescription = table.Column<string>(maxLength: 250, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    SubTotal = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(10, 2)", nullable: true),
                    SelectedDeliveryDate = table.Column<DateTime>(type: "date", nullable: true),
                    SelectedDeliverySlotTime = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.id);
                    table.ForeignKey(
                        name: "FK__orders__staff_id__49C3F6B7",
                        column: x => x.staff_id,
                        principalSchema: "sales",
                        principalTable: "Staff",
                        principalColumn: "staff_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__orders__store_id__48CFD27E",
                        column: x => x.store_id,
                        principalSchema: "sales",
                        principalTable: "Store",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__orders__customer__47DBAE45",
                        column: x => x.user_id,
                        principalSchema: "sales",
                        principalTable: "Customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Career-Order",
                schema: "dbo",
                columns: table => new
                {
                    Career_id = table.Column<int>(nullable: false),
                    Order_id = table.Column<int>(nullable: false),
                    AssignedTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Career-Order", x => new { x.Career_id, x.Order_id });
                    table.ForeignKey(
                        name: "FK_Career-Order_Career-Order",
                        column: x => x.Career_id,
                        principalSchema: "dbo",
                        principalTable: "Career",
                        principalColumn: "Career_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Career-Order_orders",
                        column: x => x.Order_id,
                        principalSchema: "sales",
                        principalTable: "Order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                schema: "dbo",
                columns: table => new
                {
                    Comment_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(nullable: true),
                    Product_id = table.Column<int>(nullable: true),
                    Store_id = table.Column<int>(nullable: true),
                    Order_id = table.Column<int>(nullable: true),
                    CommentPoint = table.Column<decimal>(type: "decimal(18, 1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Comment_id);
                    table.ForeignKey(
                        name: "FK_Comment_Orders",
                        column: x => x.Order_id,
                        principalSchema: "sales",
                        principalTable: "Order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_Products",
                        column: x => x.Product_id,
                        principalSchema: "production",
                        principalTable: "Product",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_stores",
                        column: x => x.Store_id,
                        principalSchema: "sales",
                        principalTable: "Store",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                schema: "dbo",
                columns: table => new
                {
                    Purchase_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelatedOrder_id = table.Column<int>(nullable: true),
                    Store_id = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplies", x => x.Purchase_id);
                    table.ForeignKey(
                        name: "FK_Supplies_orders",
                        column: x => x.RelatedOrder_id,
                        principalSchema: "sales",
                        principalTable: "Order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Supplies_stores",
                        column: x => x.Store_id,
                        principalSchema: "sales",
                        principalTable: "Store",
                        principalColumn: "store_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                schema: "sales",
                columns: table => new
                {
                    item_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_id = table.Column<int>(nullable: false),
                    product_id = table.Column<int>(nullable: false),
                    quantity = table.Column<int>(nullable: false),
                    list_price = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    discount = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    IsDelivered = table.Column<int>(nullable: true),
                    AlternativeItem_id = table.Column<int>(nullable: true),
                    Location_id = table.Column<int>(nullable: true),
                    ProcessPhase = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_items", x => x.item_id);
                    table.ForeignKey(
                        name: "FK_order_items_order_items",
                        column: x => x.AlternativeItem_id,
                        principalSchema: "sales",
                        principalTable: "OrderItem",
                        principalColumn: "item_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Locations",
                        column: x => x.Location_id,
                        principalSchema: "dbo",
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__order_items__order__4D94879B",
                        column: x => x.order_id,
                        principalSchema: "sales",
                        principalTable: "Order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__order_ite__produ__4E88ABD4",
                        column: x => x.product_id,
                        principalSchema: "production",
                        principalTable: "Product",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order_Slots",
                schema: "tekyerco_kozmi",
                columns: table => new
                {
                    Order_id = table.Column<int>(nullable: false),
                    Slot_id = table.Column<int>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Slots", x => new { x.Order_id, x.Slot_id });
                    table.ForeignKey(
                        name: "FK_Order_Slots_Order",
                        column: x => x.Order_id,
                        principalSchema: "sales",
                        principalTable: "Order",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Slots_SlotPattern",
                        column: x => x.Slot_id,
                        principalSchema: "dbo",
                        principalTable: "Slot",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_Area_id",
                schema: "dbo",
                table: "Address",
                column: "Area_id");

            migrationBuilder.CreateIndex(
                name: "IX_Address_PostCode_id",
                schema: "dbo",
                table: "Address",
                column: "PostCode_id");

            migrationBuilder.CreateIndex(
                name: "IX_Address_Region",
                schema: "dbo",
                table: "Address",
                column: "Region");

            migrationBuilder.CreateIndex(
                name: "IX_Address_Street_id",
                schema: "dbo",
                table: "Address",
                column: "Street_id");

            migrationBuilder.CreateIndex(
                name: "IX_Address_User_id",
                schema: "dbo",
                table: "Address",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Career_CareerAddress_id",
                schema: "dbo",
                table: "Career",
                column: "CareerAddress_id");

            migrationBuilder.CreateIndex(
                name: "IX_Career_CareerCity_id",
                schema: "dbo",
                table: "Career",
                column: "CareerCity_id");

            migrationBuilder.CreateIndex(
                name: "IX_Career_CareerDeliveryRegion_id",
                schema: "dbo",
                table: "Career",
                column: "CareerDeliveryRegion_id");

            migrationBuilder.CreateIndex(
                name: "IX_Career_CareerPostCode_id",
                schema: "dbo",
                table: "Career",
                column: "CareerPostCode_id");

            migrationBuilder.CreateIndex(
                name: "IX_Career-Order_Order_id",
                schema: "dbo",
                table: "Career-Order",
                column: "Order_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_Customer_id",
                schema: "dbo",
                table: "Cart",
                column: "Customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_Product_id",
                schema: "dbo",
                table: "CartItem",
                column: "Product_id");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_Store_id",
                schema: "dbo",
                table: "CartItem",
                column: "Store_id");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_Voucher_id",
                schema: "dbo",
                table: "CartItem",
                column: "Voucher_id");

            migrationBuilder.CreateIndex(
                name: "IX_City_Country_id",
                schema: "dbo",
                table: "City",
                column: "Country_id");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_Order_id",
                schema: "dbo",
                table: "Comment",
                column: "Order_id");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_Product_id",
                schema: "dbo",
                table: "Comment",
                column: "Product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_Store_id",
                schema: "dbo",
                table: "Comment",
                column: "Store_id");

            migrationBuilder.CreateIndex(
                name: "IX_Customer-Address_AddressId",
                schema: "dbo",
                table: "Customer-Address",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_Address_id",
                schema: "dbo",
                table: "Location",
                column: "Address_id");

            migrationBuilder.CreateIndex(
                name: "IX_Location_Career_id",
                schema: "dbo",
                table: "Location",
                column: "Career_id");

            migrationBuilder.CreateIndex(
                name: "IX_Location_Postcode_id",
                schema: "dbo",
                table: "Location",
                column: "Postcode_id");

            migrationBuilder.CreateIndex(
                name: "IX_Location_Store_id",
                schema: "dbo",
                table: "Location",
                column: "Store_id");

            migrationBuilder.CreateIndex(
                name: "IX_Postcode_AreaCode_id",
                schema: "dbo",
                table: "Postcode",
                column: "AreaCode_id");

            migrationBuilder.CreateIndex(
                name: "IX_Postcode_Location_id",
                schema: "dbo",
                table: "Postcode",
                column: "Location_id");

            migrationBuilder.CreateIndex(
                name: "IX_Postcode_PostCodeDistrict_id",
                schema: "dbo",
                table: "Postcode",
                column: "PostCodeDistrict_id");

            migrationBuilder.CreateIndex(
                name: "IX_Postcode_Sector_id",
                schema: "dbo",
                table: "Postcode",
                column: "Sector_id");

            migrationBuilder.CreateIndex(
                name: "IX_Product-AlternateProduct_RelatedProduct_id",
                schema: "dbo",
                table: "Product-AlternateProduct",
                column: "RelatedProduct_id");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItem_Career_id",
                schema: "dbo",
                table: "PurchaseItem",
                column: "Career_id");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItem_Location_id",
                schema: "dbo",
                table: "PurchaseItem",
                column: "Location_id");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItem_Product_id",
                schema: "dbo",
                table: "PurchaseItem",
                column: "Product_id");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItem_Purchase_id",
                schema: "dbo",
                table: "PurchaseItem",
                column: "Purchase_id");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseItem_Store_id",
                schema: "dbo",
                table: "PurchaseItem",
                column: "Store_id");

            migrationBuilder.CreateIndex(
                name: "IX_Region_City_id",
                schema: "dbo",
                table: "Region",
                column: "City_id");

            migrationBuilder.CreateIndex(
                name: "IX_Region_Country_id",
                schema: "dbo",
                table: "Region",
                column: "Country_id");

            migrationBuilder.CreateIndex(
                name: "IX_Region_District_id",
                schema: "dbo",
                table: "Region",
                column: "District_id");

            migrationBuilder.CreateIndex(
                name: "IX_Region-Street_Street_id",
                schema: "dbo",
                table: "Region-Street",
                column: "Street_id");

            migrationBuilder.CreateIndex(
                name: "IX_Street_Area",
                schema: "dbo",
                table: "Street",
                column: "Area");

            migrationBuilder.CreateIndex(
                name: "IX_Street_City",
                schema: "dbo",
                table: "Street",
                column: "City");

            migrationBuilder.CreateIndex(
                name: "IX_Street_Country",
                schema: "dbo",
                table: "Street",
                column: "Country");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_RelatedOrder_id",
                schema: "dbo",
                table: "Supplier",
                column: "RelatedOrder_id");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_Store_id",
                schema: "dbo",
                table: "Supplier",
                column: "Store_id");

            migrationBuilder.CreateIndex(
                name: "IX_Category_StoreCategory_id",
                schema: "production",
                table: "Category",
                column: "StoreCategory_id");

            migrationBuilder.CreateIndex(
                name: "IX_Category_UpCategory_id",
                schema: "production",
                table: "Category",
                column: "UpCategory_id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Brand_id",
                schema: "production",
                table: "Product",
                column: "Brand_id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Category_id",
                schema: "production",
                table: "Product",
                column: "Category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_product_id",
                schema: "production",
                table: "Stock",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_staff_id",
                schema: "sales",
                table: "Order",
                column: "staff_id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_store_id",
                schema: "sales",
                table: "Order",
                column: "store_id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_user_id",
                schema: "sales",
                table: "Order",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_AlternativeItem_id",
                schema: "sales",
                table: "OrderItem",
                column: "AlternativeItem_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_Location_id",
                schema: "sales",
                table: "OrderItem",
                column: "Location_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_order_id",
                schema: "sales",
                table: "OrderItem",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_product_id",
                schema: "sales",
                table: "OrderItem",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "UQ__Staffs__AB6E61640B97E2B6",
                schema: "sales",
                table: "Staff",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_manager_id",
                schema: "sales",
                table: "Staff",
                column: "manager_id");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_store_id",
                schema: "sales",
                table: "Staff",
                column: "store_id");

            migrationBuilder.CreateIndex(
                name: "IX_Store_Brand_id",
                schema: "sales",
                table: "Store",
                column: "Brand_id");

            migrationBuilder.CreateIndex(
                name: "IX_Store_City_id",
                schema: "sales",
                table: "Store",
                column: "City_id");

            migrationBuilder.CreateIndex(
                name: "IX_Store_Country_id",
                schema: "sales",
                table: "Store",
                column: "Country_id");

            migrationBuilder.CreateIndex(
                name: "IX_Store_PostCode_id",
                schema: "sales",
                table: "Store",
                column: "PostCode_id");

            migrationBuilder.CreateIndex(
                name: "IX_Store_StoreCategory_id",
                schema: "sales",
                table: "Store",
                column: "StoreCategory_id");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_Address_id",
                schema: "tekyerco_kozmi",
                table: "Contact",
                column: "Address_id");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_Store_id",
                schema: "tekyerco_kozmi",
                table: "Contact",
                column: "Store_id");

            migrationBuilder.CreateIndex(
                name: "IX_FavoredProduct_Cumstomer_id",
                schema: "tekyerco_kozmi",
                table: "FavoredProduct",
                column: "Cumstomer_id");

            migrationBuilder.CreateIndex(
                name: "IX_FavoredProduct_Store_id",
                schema: "tekyerco_kozmi",
                table: "FavoredProduct",
                column: "Store_id");

            migrationBuilder.CreateIndex(
                name: "IX_FavoredStore_Category_id",
                schema: "tekyerco_kozmi",
                table: "FavoredStore",
                column: "Category_id");

            migrationBuilder.CreateIndex(
                name: "IX_FavoredStore_Customer_id",
                schema: "tekyerco_kozmi",
                table: "FavoredStore",
                column: "Customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_FilterStore-Store_StoreFeature_id",
                schema: "tekyerco_kozmi",
                table: "FilterStore-Store",
                column: "StoreFeature_id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Slots_Slot_id",
                schema: "tekyerco_kozmi",
                table: "Order_Slots",
                column: "Slot_id");

            migrationBuilder.CreateIndex(
                name: "IX_Postcode_Stores_Store_id",
                schema: "tekyerco_kozmi",
                table: "Postcode_Stores",
                column: "Store_id");

            migrationBuilder.CreateIndex(
                name: "IX_PostCode-Distance_PostCode_id",
                schema: "tekyerco_kozmi",
                table: "PostCode-Distance",
                column: "PostCode_id");

            migrationBuilder.CreateIndex(
                name: "IX_PostCode-Distance_SecondPostCode_id",
                schema: "tekyerco_kozmi",
                table: "PostCode-Distance",
                column: "SecondPostCode_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products-Stores_Product_id",
                schema: "tekyerco_kozmi",
                table: "Products-Stores",
                column: "Product_id");

            migrationBuilder.CreateIndex(
                name: "IX_StoreCategory_Up",
                schema: "tekyerco_kozmi",
                table: "StoreCategory",
                column: "Up");

            migrationBuilder.CreateIndex(
                name: "IX_WishList_Customer_id",
                schema: "tekyerco_kozmi",
                table: "WishList",
                column: "Customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItem_Product_id",
                schema: "tekyerco_kozmi",
                table: "WishlistItem",
                column: "Product_id");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItem_WishList_id",
                schema: "tekyerco_kozmi",
                table: "WishlistItem",
                column: "WishList_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Careers_Postcodes",
                schema: "dbo",
                table: "Career",
                column: "CareerPostCode_id",
                principalSchema: "dbo",
                principalTable: "Postcode",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Careers_Address",
                schema: "dbo",
                table: "Career",
                column: "CareerAddress_id",
                principalSchema: "dbo",
                principalTable: "Address",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer-Address_Address",
                schema: "dbo",
                table: "Customer-Address",
                column: "AddressId",
                principalSchema: "dbo",
                principalTable: "Address",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Postcodes",
                schema: "dbo",
                table: "Location",
                column: "Postcode_id",
                principalSchema: "dbo",
                principalTable: "Postcode",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Address",
                schema: "dbo",
                table: "Location",
                column: "Address_id",
                principalSchema: "dbo",
                principalTable: "Address",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_stores",
                schema: "dbo",
                table: "Location",
                column: "Store_id",
                principalSchema: "sales",
                principalTable: "Store",
                principalColumn: "store_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Area",
                schema: "dbo",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Streets_Areas",
                schema: "dbo",
                table: "Street");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_Postcodes",
                schema: "dbo",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Careers_Postcodes",
                schema: "dbo",
                table: "Career");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Postcodes",
                schema: "dbo",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Postcodes",
                schema: "sales",
                table: "Store");

            migrationBuilder.DropTable(
                name: "Career-Order",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CartItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Comment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Customer-Address",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Image",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Payment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Product-AlternateProduct",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PurchaseItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Region-Street",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Supplier",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Stock",
                schema: "production");

            migrationBuilder.DropTable(
                name: "OrderItem",
                schema: "sales");

            migrationBuilder.DropTable(
                name: "Attribute",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "Contact",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "FavoredProduct",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "FavoredStore",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "FilterStore-Store",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "Layout",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "Layout_LayoutItem",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "LayoutItem",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "Order_Slots",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "Postcode_DeliveryDate",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "Postcode_Stores",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "PostCode-Distance",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "Products-Stores",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "ShopGroup",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "ShopGroup-Product",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "SlotPattern",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "User_ShoppingCartProducts",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "WishlistItem",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "Cart",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Voucher",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Purchase",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FilterStore",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "Order",
                schema: "sales");

            migrationBuilder.DropTable(
                name: "Slot",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "production");

            migrationBuilder.DropTable(
                name: "WishList",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "Staff",
                schema: "sales");

            migrationBuilder.DropTable(
                name: "ProductBrand",
                schema: "production");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "production");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "sales");

            migrationBuilder.DropTable(
                name: "Region",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "District",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Postcode",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AreaCode",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "Location",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PostCodeDistrict",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "PostCodeSector",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "Career",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Store",
                schema: "sales");

            migrationBuilder.DropTable(
                name: "Address",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SellerBrand",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "StoreCategory",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "DeliveryRegion",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Street",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "User",
                schema: "tekyerco_kozmi");

            migrationBuilder.DropTable(
                name: "City",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "dbo");

            migrationBuilder.RenameTable(
                name: "RefreshToken",
                schema: "tekyerco_doory",
                newName: "RefreshToken");

            migrationBuilder.RenameTable(
                name: "Accounts",
                schema: "tekyerco_doory",
                newName: "Accounts");
        }
    }
}
