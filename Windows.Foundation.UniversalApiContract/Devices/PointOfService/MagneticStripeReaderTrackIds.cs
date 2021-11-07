// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderTrackIds
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Defines the constants that indicates the device track ID to read.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MagneticStripeReaderTrackIds
  {
    /// <summary>No track ID</summary>
    None = 0,
    /// <summary>Read track 1</summary>
    Track1 = 1,
    /// <summary>Read track 2</summary>
    Track2 = 2,
    /// <summary>Read track 3</summary>
    Track3 = 4,
    /// <summary>Read track 4</summary>
    Track4 = 8,
  }
}
