#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Runtime.CompilerServices;

#endregion

namespace QMediaVSIX.Core.Collections;

public class KeyNullException : ArgumentNullException {
	public KeyNullException( [CallerMemberName] string ParamName = null! ) : base(ParamName, "Key may not be null.") { }
}