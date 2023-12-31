﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RazorPages.Areas.Identity.Data;
using RazorPages.Models;

namespace RazorPages.Data;

public class RazorPagesContext : IdentityDbContext<RazorPagesUser>
{
    public RazorPagesContext(DbContextOptions<RazorPagesContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<RazorPages.Models.Contact> Contact { get; set; } = default!;
}
