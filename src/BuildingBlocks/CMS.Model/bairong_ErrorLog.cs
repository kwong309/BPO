namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class bairong_ErrorLog
    {
        public int Id { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(255)]
        public string Message { get; set; }

        [Column(TypeName = "ntext")]
        public string Stacktrace { get; set; }

        [Column(TypeName = "ntext")]
        public string Summary { get; set; }
    }
}
