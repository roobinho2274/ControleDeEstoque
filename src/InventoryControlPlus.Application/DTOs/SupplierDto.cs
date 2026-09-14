public class SupplierDto
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public string CNPJ { get; set; } = string.Empty;
	public string Phone { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public int TotalProducts { get; set; }
}

public class CreateSupplierDto
{
	public string Name { get; set; } = string.Empty;
	public string CNPJ { get; set; } = string.Empty;
	public string Phone { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
}

public class UpdateSupplierDto
{
	public string Name { get; set; } = string.Empty;
	public string CNPJ { get; set; } = string.Empty;
	public string Phone { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
}