using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MovimentConfiguration : IEntityTypeConfiguration<Moviment>
{
	public void Configure(EntityTypeBuilder<Moviment> builder)
	{
		builder.ToTable("Moviments");
		builder.HasKey(m => m.Id);
		builder.Property(m => m.ProductId)
			.IsRequired();
		builder.Property(m => m.Quantity)
			.IsRequired();
		builder.Property(m => m.Type)
			.IsRequired();
		builder.Property(m => m.MovementDate)
			.IsRequired();		
	}
}