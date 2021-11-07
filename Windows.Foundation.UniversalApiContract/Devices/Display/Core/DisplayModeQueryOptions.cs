// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayModeQueryOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify options for a mode query operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Flags]
  public enum DisplayModeQueryOptions : uint
  {
    /// <summary>Indicates no options.</summary>
    None = 0,
    /// <summary>Indicates that only return modes whose source resolution and target resolution exactly match the connected monitor's native mode should be returned.</summary>
    OnlyPreferredResolution = 1,
  }
}
