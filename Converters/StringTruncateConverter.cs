using System.Globalization;

namespace QMediaVSIX.Converters; 

internal class StringTruncateConverter : ValueConverter<string, string> {

    int _MaxChars = 30;
    /// <summary>
    /// The maximum amount of allowed characters (inclusive) until truncating of the text occurs.
    /// </summary>
    public int MaxChars {
        get => _MaxChars;
        set => RaiseAndSetIfChanged(ref _MaxChars, value);
    }

    /// <inheritdoc />
    public override bool CanReverse => false;

    /// <inheritdoc />
    public override bool CanForwardWhenNull => true;

    /// <inheritdoc />
    public override string Forward( string From, object? Parameter = null, CultureInfo? Culture = null ) {
        int L = From.Length;
        if ( L > MaxChars ) {
            return From[..(MaxChars - 3)] + "...";
        }
        return From;
    }

    /// <inheritdoc />
    public override string ForwardWhenNull( object? Parameter = null, CultureInfo? Culture = null ) => string.Empty;

    /// <inheritdoc />
    public override string? Reverse( string To, object? Parameter = null, CultureInfo? Culture = null ) => null;
}