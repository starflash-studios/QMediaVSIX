// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Provides capabilities information for the magnetic stripe reader.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MagneticStripeReaderCapabilities : IMagneticStripeReaderCapabilities
  {
    /// <summary>Gets the type of card authentication data that is supported by the device.</summary>
    /// <returns>The string containing the type of card authentication data.</returns>
    public extern string CardAuthentication { [MethodImpl] get; }

    /// <summary>Gets the supported encryption algorithm.</summary>
    /// <returns>The supported encryption algorithm.</returns>
    public extern uint SupportedEncryptionAlgorithms { [MethodImpl] get; }

    /// <summary>Gets the authentication level supported by the device.</summary>
    /// <returns>The supported authentication level.</returns>
    public extern MagneticStripeReaderAuthenticationLevel AuthenticationLevel { [MethodImpl] get; }

    /// <summary>Indicates whether the device supports ISO cards.</summary>
    /// <returns>True if the device supports ISO cards; otherwise, false.</returns>
    public extern bool IsIsoSupported { [MethodImpl] get; }

    /// <summary>Indicates whether device supports JIS Type-I cards.</summary>
    /// <returns>True if the device support JIS Type-I cards; otherwise, false.</returns>
    public extern bool IsJisOneSupported { [MethodImpl] get; }

    /// <summary>Indicates whether the device supports JIS Type-II cards.</summary>
    /// <returns>True if the device supports JIS Type-II cards; otherwise, false.</returns>
    public extern bool IsJisTwoSupported { [MethodImpl] get; }

    /// <summary>Gets the power reporting capabilities of the device.</summary>
    /// <returns>The power reporting capabilities of the device.</returns>
    public extern UnifiedPosPowerReportingType PowerReportingType { [MethodImpl] get; }

    /// <summary>Indicates whether the device supports reporting of usage statistics.</summary>
    /// <returns>True if the device supports reporting of usage statistics; otherwise, false.</returns>
    public extern bool IsStatisticsReportingSupported { [MethodImpl] get; }

    /// <summary>Indicates whether the device supports updating of usage statistics.</summary>
    /// <returns>True if the device supports updating of statistics; otherwise, false.</returns>
    public extern bool IsStatisticsUpdatingSupported { [MethodImpl] get; }

    /// <summary>Indicates whether the device is capable of masking track data.</summary>
    /// <returns>True if the device is capable of masking track data; otherwise, false.</returns>
    public extern bool IsTrackDataMaskingSupported { [MethodImpl] get; }

    /// <summary>Indicates whether the devices is able to transmit start and end sentinels.</summary>
    /// <returns>True if the device is able to transmit start and end sentinels; otherwise, false.</returns>
    public extern bool IsTransmitSentinelsSupported { [MethodImpl] get; }
  }
}
