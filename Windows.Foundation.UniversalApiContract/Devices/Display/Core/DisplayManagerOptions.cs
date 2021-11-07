// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayManagerOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify options for the DisplayManager.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Flags]
  public enum DisplayManagerOptions : uint
  {
    /// <summary>Specifies no options.</summary>
    None = 0,
    /// <summary>Restricts scan out to devices created by this DisplayManager object, or to DisplaySource objects created using a shared handle provided by a path owned by this **DisplayManager**.</summary>
    EnforceSourceOwnership = 1,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 851968)] VirtualRefreshRateAware = 2,
  }
}
