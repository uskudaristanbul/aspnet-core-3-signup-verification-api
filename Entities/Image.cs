using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    [Table("Image", Schema = "dbo")]
    public partial class Image
    {
        [Key]
        [Column("Image_id")]
        public int ImageId { get; set; }
        public string ImageLink { get; set; }
        public int? ImageType { get; set; }
        public int? ImageSize { get; set; }
        [Column("Product_id")]
        public int? ProductId { get; set; }
        [Column("Category_id")]
        public int? CategoryId { get; set; }
        [Column("Comment_id")]
        public int? CommentId { get; set; }
        public int? MotherImage { get; set; }
    }
}
