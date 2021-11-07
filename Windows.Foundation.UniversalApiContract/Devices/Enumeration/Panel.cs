// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.Panel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Indicates the location of a panel on a computer. This enumeration is used for indicating the physical location of a device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum Panel
  {
    /// <summary>The location of the panel is unknown.</summary>
    Unknown,
    /// <summary>The front panel of the computer.</summary>
    Front,
    /// <summary>The back panel of the computer.</summary>
    Back,
    /// <summary>The top panel of the computer.</summary>
    Top,
    /// <summary>The bottom panel of the computer.</summary>
    Bottom,
    /// <summary>The left panel of the computer.</summary>
    Left,
    /// <summary>The right panel of the computer.</summary>
    Right,
  }
}
