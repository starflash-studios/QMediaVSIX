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

public class FloatToPercentConverter : ValueConverter<float, int> {
  /// <inheritdoc />
  public override bool CanReverse => true;

  /// <summary>
  /// Whether to allow value conversions to the default value when converting from null.
  /// </summary>
  public bool AllowNull { get; set; }

  /// <inheritdoc />
  public override int Forward( float From, object? Parameter = null, CultureInfo? Culture = null ) => (int)Math.Round(From * 100);

  /// <inheritdoc />
  public override int ForwardWhenNull( object? Parameter = null, CultureInfo? Culture = null ) => AllowNull ? default : base.ForwardWhenNull(Parameter, Culture);

  /// <inheritdoc />
  public override float Reverse( int To, object? Parameter = null, CultureInfo? Culture = null ) => To / 100.0f;

  /// <inheritdoc />
  public override float ReverseWhenNull( object? Parameter = null, CultureInfo? Culture = null ) => AllowNull ? default : base.ForwardWhenNull(Parameter, Culture);
}