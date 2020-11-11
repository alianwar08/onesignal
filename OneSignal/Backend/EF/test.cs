namespace Backend.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("test")]
    public partial class test
    {
        [Key]
        public int pk { get; set; }

        public int? i { get; set; }

        [StringLength(50)]
        public string s { get; set; }

        [Required]
        [StringLength(50)]
        public string s2 { get; set; }
    }
}
