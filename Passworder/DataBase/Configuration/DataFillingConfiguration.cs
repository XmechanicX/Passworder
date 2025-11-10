using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Passworder.Model;

namespace Passworder.DataBase.Configuration
{
    public class DataFillingConfiguration : IEntityTypeConfiguration<DataFilling>
    {
        public void Configure(EntityTypeBuilder<DataFilling> builder)
        {
            builder.ToTable("DataFilling");
            builder.HasKey(x => x.Id).HasName("PK_Id");
        }
    }
}
