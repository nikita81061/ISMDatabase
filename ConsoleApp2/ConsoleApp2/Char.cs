namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Char")]
    public partial class Char
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string NameOfChar { get; set; }
    }
}
