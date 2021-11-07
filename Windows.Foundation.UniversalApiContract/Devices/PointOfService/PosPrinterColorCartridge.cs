// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterColorCartridge
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Describes the color cartridges that the point-of-service printer can use for printing.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PosPrinterColorCartridge
  {
    /// <summary>An unknown color cartridge.</summary>
    Unknown,
    /// <summary>The primary color cartridge.</summary>
    Primary,
    /// <summary>The first custom color cartridge, which provides a secondary color, usually red.</summary>
    Custom1,
    /// <summary>The second custom color cartridge.</summary>
    Custom2,
    /// <summary>The third custom color cartridge.</summary>
    Custom3,
    /// <summary>The fourth custom color cartridge.</summary>
    Custom4,
    /// <summary>The fifth custom color cartridge.</summary>
    Custom5,
    /// <summary>The sixth custom color cartridge.</summary>
    Custom6,
    /// <summary>The cyan cartridge for full color printing.</summary>
    Cyan,
    /// <summary>The magenta cartridge for full color printing.</summary>
    Magenta,
    /// <summary>The yellow cartridge for full color printing.</summary>
    Yellow,
  }
}
