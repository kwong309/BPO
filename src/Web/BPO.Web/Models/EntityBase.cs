using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BPO.Web.Models
{
    public class EntityBase
    {
        [Key]
        [Required]
        [Display(Name = "本表数据编号")]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [DataType(DataType.Text)]
        public string guid { get; set; }
        public DateTime CreatedTime { get; set; }
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Creator { get; set; }
        public EntityBase()
        {
            if (this.CreatedTime == DateTime.MinValue)
            {
                this.CreatedTime = DateTime.Now;
            }
        }
        public void NewId()
        {
            this.guid = Guid.NewGuid().ToString();
            this.CreatedTime = DateTime.Now;
        }

    }
}
