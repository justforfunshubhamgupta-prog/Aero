namespace Aero.Core.Clipboard;

public interface IClipboardRepository
{
    Task<ClipboardItem> AddAsync(
        ClipboardItem item,
        CancellationToken cancellationToken = default);

    Task<IReadOnlyList<ClipboardItem>> GetRecentAsync(
        int limit = 50,
        CancellationToken cancellationToken = default);

    Task<IReadOnlyList<ClipboardItem>> SearchAsync(
        string query,
        CancellationToken cancellationToken = default);

    Task SetPinnedAsync(
        long id,
        bool isPinned,
        CancellationToken cancellationToken = default);

    Task DeleteAsync(
        long id,
        CancellationToken cancellationToken = default);
}