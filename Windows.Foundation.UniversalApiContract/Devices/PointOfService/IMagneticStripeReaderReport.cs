// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (MagneticStripeReaderReport))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1784373319, 39344, 16776, 190, 241, 237, 223, 121, 247, 143, 230)]
  internal interface IMagneticStripeReaderReport
  {
    uint CardType { get; }

    MagneticStripeReaderTrackData Track1 { get; }

    MagneticStripeReaderTrackData Track2 { get; }

    MagneticStripeReaderTrackData Track3 { get; }

    MagneticStripeReaderTrackData Track4 { get; }

    IMapView<string, string> Properties { get; }

    IBuffer CardAuthenticationData { get; }

    uint CardAuthenticationDataLength { get; }

    IBuffer AdditionalSecurityInformation { get; }
  }
}
