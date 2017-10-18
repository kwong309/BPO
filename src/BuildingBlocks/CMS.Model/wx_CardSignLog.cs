namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class wx_CardSignLog
    {
        public int Id { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        public DateTime? SignDate { get; set; }
    }
}
