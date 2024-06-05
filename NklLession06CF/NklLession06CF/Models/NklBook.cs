using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NklLession06CF.Models
{
    public class NklBook
    {
        [Key]
        public int NklId { get; set; }
        public string NklBookId { get; set; }
        public string NklTitle { get; set; }
        public string NklAuthor { get; set; }
        public int NklYear { get; set; }
        public string NklPulisher { get; set; }
        public string NklPicture { get; set; }
        public string NklCategoryId { get; set; }
        // Thuộc tính quan hệ
        public virtual NklCategory NklCategory { get; set; }
    }
}
