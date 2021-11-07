// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterMapMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Describes the valid units of measure for point-of-service printers.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PosPrinterMapMode
  {
    /// <summary>The dot width for the point-of-service printer.</summary>
    Dots,
    /// <summary>1/1440 of an inch.</summary>
    Twips,
    /// <summary>0.001 inch.</summary>
    English,
    /// <summary>0.01 millimeter.</summary>
    Metric,
  }
}
