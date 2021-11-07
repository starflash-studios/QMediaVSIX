// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.DisplayMonitorUsageKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display
{
  /// <summary>Defines constants that specify the use to which the display is being put.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum DisplayMonitorUsageKind
  {
    /// <summary>Indicates that the display is being used as a standard monitor.</summary>
    Standard,
    /// <summary>Indicates that the display is being used as a head-mounted display.</summary>
    HeadMounted,
    /// <summary>Indicates that the display is not to be used as part of the Windows desktop, and is designed to be driven by a specific third-party application.</summary>
    SpecialPurpose,
  }
}
