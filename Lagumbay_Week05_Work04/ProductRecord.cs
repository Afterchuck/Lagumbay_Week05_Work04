namespace Lagumbay_Week05_Work04;

public class ProductRecord
{
    public string Barcode { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Origin { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public decimal Cost { get; set; }
    public decimal Price { get; set; }
    public decimal Markup { get; set; }
}
