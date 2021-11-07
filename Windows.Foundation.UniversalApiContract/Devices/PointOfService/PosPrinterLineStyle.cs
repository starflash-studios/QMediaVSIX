// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterLineStyle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Describes the line styles that a receipt or slip printer station can use to print a ruled line.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PosPrinterLineStyle
  {
    /// <summary>Prints a continuous solid line.</summary>
    SingleSolid,
    /// <summary>Prints a continuous solid line of double the normal thickness.</summary>
    DoubleSolid,
    /// <summary>Prints a sequence of short lines separated by spaces.</summary>
    Broken,
    /// <summary>Prints a sequence of short lines separated by a space, then followed by a very short line, followed by a space, then followed by a short line again.</summary>
    Chain,
  }
}
