namespace OnionArcProject.Domain.Models;

public class Gpu
{
    public Guid Id { get; set; }

    public float Frequency { get; set; }

    public Guid VenderId { get; set; }

    public virtual Vender Vender { get; set; } = null!;
}
