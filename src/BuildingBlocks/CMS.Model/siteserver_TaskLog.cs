namespace CMS.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class siteserver_TaskLog
    {
        public int Id { get; set; }

        public int TaskId { get; set; }

        [StringLength(18)]
        public string IsSuccess { get; set; }

        [StringLength(255)]
        public string ErrorMessage { get; set; }

        public DateTime? AddDate { get; set; }

        public virtual siteserver_Task siteserver_Task { get; set; }
    }
}
