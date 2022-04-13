#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiBookMVC.Models;

namespace WebApiBookMVC.Data
{
    public class WebApiBookMVCContext : DbContext
    {
        public WebApiBookMVCContext (DbContextOptions<WebApiBookMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiBookMVC.Models.Book> Book { get; set; }
    }
}
