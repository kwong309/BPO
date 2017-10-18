namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class bairong_Log
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string IpAddress { get; set; }

        public DateTime? AddDate { get; set; }

        [StringLength(255)]
        public string Action { get; set; }

        [StringLength(255)]
        public string Summary { get; set; }
    }
}
