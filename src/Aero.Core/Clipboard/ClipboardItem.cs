namespace Aero.Core.Clipboard;

public sealed class ClipboardItem
{
    public long Id { get; init; }

    public required string Content { get; init; }

    public ClipboardContentType ContentType { get; init; }

    public DateTime CreatedAt { get; init; }

    public DateTime LastUsedAt { get; set; }

    public bool IsPinned { get; set; }
}