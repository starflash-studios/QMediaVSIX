// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterPrintSide
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Describes the sides of the sheet of paper on which the point-of-service printer prints.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PosPrinterPrintSide
  {
    /// <summary>The side on which the point-of-service printer is currently printing is unknown.</summary>
    Unknown,
    /// <summary>The point-of-service printer is printing or should print on the front side of the sheet.</summary>
    Side1,
    /// <summary>The point-of-service printer is printing or should print on the back side of the sheet.</summary>
    Side2,
  }
}
