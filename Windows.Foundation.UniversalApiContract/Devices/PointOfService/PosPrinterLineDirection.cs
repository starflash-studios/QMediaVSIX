// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterLineDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Describes the possible directions that a receipt or slip printer station can use to print a ruled line.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PosPrinterLineDirection
  {
    /// <summary>Prints a horizontal ruled line.</summary>
    Horizontal,
    /// <summary>Prints a vertical ruled line.</summary>
    Vertical,
  }
}
