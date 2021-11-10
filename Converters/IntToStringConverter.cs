using System.Collections.Generic;
using System.Globalization;

namespace QMediaVSIX.Converters;

public class IntToStringConverter : ValueConverter<int, string> {
  /// <summary>
  /// The format to use for the <see cref="int.ToString(string)"/> method.
  /// </summary>
  public string? Format { get; set; }

  /// <inheritdoc />
  public override bool CanReverse => true;

  /// <inheritdoc />
  public override bool CanForwardWhenNull => true;

  /// <inheritdoc />
  public override string Forward( int From, object? Parameter = null, CultureInfo? Culture = null ) => Format is { } F ? From.ToString(F) : From.ToString();

  /// <inheritdoc />
  public override string? ForwardWhenNull( object? Parameter = null, CultureInfo? Culture = null ) => null;

  /// <inheritdoc />
  public override int Reverse( string To, object? Parameter = null, CultureInfo? Culture = null ) => int.Parse(To);
}