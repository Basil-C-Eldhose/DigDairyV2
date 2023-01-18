using Microsoft.EntityFrameworkCore;
using V2Backend.Models;

namespace V2Backend.Data
{
    public class DataContextClass:DbContext
    {
        public DataContextClass(DbContextOptions<DataContextClass> options) : base(options)
        {

        }
        public DbSet<Expense> tblexpense { get; set; }
        public DbSet<Categoryy> tblcategory { get; set; }
    }
}
