using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer;

public class AppDbContext: DbContext
{
    public virtual DbSet<Product> Products { get; set; }
}