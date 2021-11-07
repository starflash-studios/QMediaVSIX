// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterColorCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Describes the possible color cartridges that a point-of-service printer can support.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PosPrinterColorCapabilities : uint
  {
    /// <summary>Supports no color cartridges.</summary>
    None = 0,
    /// <summary>Supports a primary color cartridge.</summary>
    Primary = 1,
    /// <summary>Supports a first custom color cartridge, which provides a secondary color, usually red.</summary>
    Custom1 = 2,
    /// <summary>Supports a second custom color cartridge.</summary>
    Custom2 = 4,
    /// <summary>Supports a third custom color cartridge.</summary>
    Custom3 = 8,
    /// <summary>Supports a fourth custom color cartridge.</summary>
    Custom4 = 16, // 0x00000010
    /// <summary>Supports a fifth custom color cartridge.</summary>
    Custom5 = 32, // 0x00000020
    /// <summary>Supports a sixth custom color cartridge.</summary>
    Custom6 = 64, // 0x00000040
    /// <summary>Supports a cyan cartridge for full color printing.</summary>
    Cyan = 128, // 0x00000080
    /// <summary>Supports a magenta cartridge for full color printing.</summary>
    Magenta = 256, // 0x00000100
    /// <summary>Supports a yellow cartridge for full color printing.</summary>
    Yellow = 512, // 0x00000200
    /// <summary>Supports full color printing.</summary>
    Full = 1024, // 0x00000400
  }
}
