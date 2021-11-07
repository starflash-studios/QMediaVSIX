// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReaderCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MagneticStripeReaderCapabilities))]
  [Guid(1898479772, 50240, 17570, 164, 103, 70, 145, 117, 208, 40, 150)]
  internal interface IMagneticStripeReaderCapabilities
  {
    string CardAuthentication { get; }

    uint SupportedEncryptionAlgorithms { get; }

    MagneticStripeReaderAuthenticationLevel AuthenticationLevel { get; }

    bool IsIsoSupported { get; }

    bool IsJisOneSupported { get; }

    bool IsJisTwoSupported { get; }

    UnifiedPosPowerReportingType PowerReportingType { get; }

    bool IsStatisticsReportingSupported { get; }

    bool IsStatisticsUpdatingSupported { get; }

    bool IsTrackDataMaskingSupported { get; }

    bool IsTransmitSentinelsSupported { get; }
  }
}
