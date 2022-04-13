using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApiBookMVC.Data;
using System;
using System.Linq;

namespace WebApiBookMVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebApiBookMVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebApiBookMVCContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                   new Book
                   {
                       Title = "The C# Programming Language",
                       PublishDate = DateTime.Parse("2014-04-01"),
                       Genre = "Programming",
                       Publisher = "Wrox Press",
                       Author = "Anders Hejlsberg"
                   },
                   new Book
                   {
                       Title = "The C# Cookbook",
                       PublishDate = DateTime.Parse("2014-06-01"),
                       Genre = "Programming",
                       Publisher = "Wrox Press",
                       Author = "David Gassner"

                   },
                   new Book
                   {
                       Title = "The C# Cookbook 2nd Edition",
                       PublishDate = DateTime.Parse("2014-07-01"),
                       Genre = "Programming",
                       Publisher = "Wrox Press",
                       Author = "David Gassner"

                   },
                   new Book
                   {
                       Title = "The C# Cookbook 3rd Edition",
                       PublishDate = DateTime.Parse("2014-09-01"),
                       Genre = "Programming",
                       Publisher = "Wrox Press",
                       Author = "David Gassner"
                   }
                );
                context.SaveChanges();
            }

        }
    }
}