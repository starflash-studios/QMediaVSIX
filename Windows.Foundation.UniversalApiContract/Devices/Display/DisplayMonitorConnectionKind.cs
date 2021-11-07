// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.DisplayMonitorConnectionKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display
{
  /// <summary>Defines constants that specify an abstract method in which a display is connected (not specific to a physical protocol).</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public enum DisplayMonitorConnectionKind
  {
    /// <summary>Indicates that the display is connected internally.</summary>
    Internal,
    /// <summary>Indicates that the display is connected wired.</summary>
    Wired,
    /// <summary>Indicates that the display is connected wirelessly.</summary>
    Wireless,
    /// <summary>Indicates that the display is connected virtually.</summary>
    Virtual,
  }
}
