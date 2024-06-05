using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NklLession06CF.Models
{
    public class NklCategory
    {
        [Key]
        public int NklId { get; set; }
        public string NklCategoryName { get; set; }
        // Thuộc tính quan hệ
        public virtual ICollection<NklBook> NklBooks { get; set; }
    }
}
