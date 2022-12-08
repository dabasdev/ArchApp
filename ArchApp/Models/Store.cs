namespace ArchApp.Models;

public sealed class Store
{
    public int Id { get; set; }

    public string TheFileName { get; set; } = null!;

    public string FileEx { get; set; } = null!;

    public byte[] FileData { get; set; } = null!;
}
