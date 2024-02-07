namespace OnionArcProject.Domain;

public partial class Vender
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public float MarketShare { get; set; }

    public virtual ICollection<Gpu> Gpus { get; set; } = new List<Gpu>();
}
