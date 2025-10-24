using DIREKT_SATIS.Books;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace DIREKT_SATIS.EntityFrameworkCore;

public class BookEntityTypeConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> b)
    {
        b.ToTable(DIREKT_SATISConsts.DbTablePrefix + "Books", DIREKT_SATISConsts.DbSchema);
        b.ConfigureByConvention();
        b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        b.Property(x => x.Author).HasMaxLength(128);
    }
}
