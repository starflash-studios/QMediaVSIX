using System.Globalization;

namespace QMediaVSIX.Converters;

public class BoolToDoubleConverter : ValueConverter<bool, double> {
  /// <summary>
  /// The value to return when <see langword="true"/>.
  /// </summary>
  public double WhenTrue { get; set; } = 1.0;

  /// <summary>
  /// The value to return when <see langword="false"/>.
  /// </summary>
  public double WhenFalse { get; set; } = 0.0;

  /// <inheritdoc />
  public override double Forward( bool From, object? Parameter = null, CultureInfo? Culture = null ) => From ? WhenTrue : WhenFalse;

  /// <inheritdoc />
  public override bool Reverse( double To, object? Parameter = null, CultureInfo? Culture = null ) {
    if ( To == WhenTrue ) {
      return true;
    }

    if ( To == WhenFalse ) {
      return false;
    }

    throw new NotSupportedException($"Value of {To} is not supported for backwards conversions.");
  }

  /// <inheritdoc />
  public override bool CanReverse => true;
}