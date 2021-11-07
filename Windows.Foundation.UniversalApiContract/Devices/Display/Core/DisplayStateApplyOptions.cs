﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayStateApplyOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify options for applying a DisplayState to the system.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Flags]
  public enum DisplayStateApplyOptions : uint
  {
    /// <summary>Indicates no option.</summary>
    None = 0,
    /// <summary>Indicates that the apply operation should fail with SystemStateChanged if the system display state has changed since the DisplayState object was created. This is useful for improving reliability of an apply operation because, if it fails for this reason, then it's often better to just redo the entire operation in case the system state change resulted in different availability of modes or monitors.</summary>
    FailIfStateChanged = 1,
    /// <summary>Indicates that all modes should be re-applied to all display drivers, even if they haven't changed.</summary>
    ForceReapply = 2,
    /// <summary>Indicates that all mode list caches should be regenerated by the system.</summary>
    ForceModeEnumeration = 4,
  }
}