using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public partial class Layout
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int? Region { get; set; }
        public int? Country { get; set; }
        [Column("MainPage_TopMenuItems")]
        [StringLength(700)]
        public string MainPageTopMenuItems { get; set; }
    }
}
