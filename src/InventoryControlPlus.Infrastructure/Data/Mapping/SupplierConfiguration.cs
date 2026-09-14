using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class SupplierConfiguration: IEntityTypeConfiguration<Supplier>
{
	public void Configure(EntityTypeBuilder<Supplier> builder)
	{
		builder.ToTable("Suppliers");
		builder.HasKey(s => s.Id);
		builder.Property(s => s.Name)
			.IsRequired()
			.HasMaxLength(100);
		builder.Property(s => s.CNPJ)
			.IsRequired()
			.HasMaxLength(14);
		builder.Property(s => s.Email)
			.HasMaxLength(100);
		builder.Property(s => s.Phone)
			.HasMaxLength(15);
	}
}