#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Linq;

using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

#endregion

namespace QMediaVSIX.Converters;

public class MultipleConverters : List<IValueConverter>, IValueConverter, IMultiValueConverter {
  #region IValueConverter Members

  public object Convert( object Value, Type TargetType, object Parameter, CultureInfo Culture ) => this.Aggregate(Value, ( Current, Converter ) => Converter.Convert(Current, TargetType, Parameter, Culture));

  public object ConvertBack( object Value, Type TargetType, object Parameter, CultureInfo Culture ) => this.AsReversed().Aggregate(Value, ( Current, Converter ) => Converter.Convert(Current, TargetType, Parameter, Culture));

  public object Convert( object[] Values, Type TargetType, object Parameter, CultureInfo Culture ) => Convert(Values as object, TargetType, Parameter, Culture);

  public object[] ConvertBack( object Value, Type[] TargetTypes, object Parameter, CultureInfo Culture ) => throw new NotImplementedException();

  #endregion
}