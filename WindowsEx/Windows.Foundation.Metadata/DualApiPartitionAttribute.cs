﻿#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.Runtime.CompilerServices;

#endregion

namespace Windows.Foundation.Metadata {
  /// <summary>Indicates that the type is supported in desktop apps and in UWP apps.</summary>
  [AttributeName(@"dualapipartition")]
  [AttributeUsage(AttributeTargets.RuntimeClass)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public sealed class DualApiPartitionAttribute : Attribute {
    /// <summary>
    /// </summary>
    public uint Version;

    /// <summary>Creates and initialises a new instance of the attribute.</summary>
    [MethodImpl]
    public extern DualApiPartitionAttribute();
  }
}