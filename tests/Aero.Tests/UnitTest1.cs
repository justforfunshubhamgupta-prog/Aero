using Aero.Core.Clipboard;

namespace Aero.Tests;

public class ClipboardContentClassifierTests
{
    private readonly ClipboardContentClassifier _classifier = new();

    [Fact]
    public void Classify_PlainText_ReturnsText()
    {
        var result = _classifier.Classify("Hello, this is a normal message.");

        Assert.Equal(ClipboardContentType.Text, result);
    }

    [Fact]
    public void Classify_HttpsUrl_ReturnsUrl()
    {
        var result = _classifier.Classify("https://github.com");

        Assert.Equal(ClipboardContentType.Url, result);
    }

    [Fact]
    public void Classify_HttpUrl_ReturnsUrl()
    {
        var result = _classifier.Classify("http://example.com");

        Assert.Equal(ClipboardContentType.Url, result);
    }

    [Fact]
    public void Classify_Code_ReturnsCode()
    {
        var result = _classifier.Classify("public class Test { return true; }");

        Assert.Equal(ClipboardContentType.Code, result);
    }

    [Fact]
    public void Classify_EmptyText_ReturnsText()
    {
        var result = _classifier.Classify("");

        Assert.Equal(ClipboardContentType.Text, result);
    }

    [Fact]
    public void Classify_Whitespace_ReturnsText()
    {
        var result = _classifier.Classify("   ");

        Assert.Equal(ClipboardContentType.Text, result);
    }
}