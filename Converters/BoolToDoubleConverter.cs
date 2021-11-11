#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Globalization;

#endregion

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