namespace CMS.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class siteserver_Task
    {

        public siteserver_Task()
        {
            siteserver_TaskLog = new HashSet<siteserver_TaskLog>();
        }

        [Key]
        public int TaskId { get; set; }

        [StringLength(50)]
        public string TaskName { get; set; }

        [StringLength(18)]
        public string IsSystemTask { get; set; }

        public int? PublishmentSystemId { get; set; }

        [StringLength(50)]
        public string ServiceType { get; set; }

        [Column(TypeName = "ntext")]
        public string ServiceParameters { get; set; }

        [StringLength(50)]
        public string FrequencyType { get; set; }

        public int? PeriodIntervalMinute { get; set; }

        public int? StartDay { get; set; }

        public int? StartWeekday { get; set; }

        public int? StartHour { get; set; }

        [StringLength(18)]
        public string IsEnabled { get; set; }

        public DateTime? AddDate { get; set; }

        public DateTime? LastExecuteDate { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public DateTime? OnlyOnceDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<siteserver_TaskLog> siteserver_TaskLog { get; set; }
    }
}
