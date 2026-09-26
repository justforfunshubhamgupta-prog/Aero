using System.Text.RegularExpressions;

namespace Aero.Core.Clipboard;

public sealed class ClipboardContentClassifier
{
    private static readonly Regex UrlRegex = new(
        @"^https?://\S+$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

    private static readonly string[] CodeIndicators =
    [
        "{",
        "}",
        "=>",
        "function ",
        "class ",
        "public ",
        "private ",
        "const ",
        "let ",
        "var ",
        "using ",
        "import ",
        "def ",
        "return "
    ];

    public ClipboardContentType Classify(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
        {
            return ClipboardContentType.Text;
        }

        var trimmed = content.Trim();

        if (UrlRegex.IsMatch(trimmed))
        {
            return ClipboardContentType.Url;
        }

        if (LooksLikeCode(trimmed))
        {
            return ClipboardContentType.Code;
        }

        return ClipboardContentType.Text;
    }

    private static bool LooksLikeCode(string content)
    {
        return CodeIndicators.Any(
            indicator => content.Contains(
                indicator,
                StringComparison.Ordinal));
    }
}