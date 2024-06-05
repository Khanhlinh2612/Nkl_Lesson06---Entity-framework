using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NklLession06CF.Models
{
    public class NklBookStore:DbContext
    {
        public NklBookStore() : base("NklBookStoreConnectionString") { }
        // Khai báo các thuộc tính tương ứng với các bảng trong cơ sở dữ liệu
        public DbSet<NklCategory> NklCategories { get; set; }
        public DbSet<NklBook> NklBooks { get; set; }
    }
}