using Microsoft.EntityFrameworkCore;
using Project.WPF.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Project.WPF.DataBase
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);
        }
    }
}
