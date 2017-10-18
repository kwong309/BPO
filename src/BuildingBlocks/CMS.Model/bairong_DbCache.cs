namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class bairong_DbCache
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string CacheKey { get; set; }

        [StringLength(500)]
        public string CacheValue { get; set; }

        public DateTime? AddDate { get; set; }
    }
}
