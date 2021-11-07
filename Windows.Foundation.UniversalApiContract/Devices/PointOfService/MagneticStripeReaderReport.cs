// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  /// <summary>Contains data from the recently swiped card.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MagneticStripeReaderReport : IMagneticStripeReaderReport
  {
    /// <summary>Gets the card type identifier for the recently swiped card.</summary>
    /// <returns>The card type identifier.</returns>
    public extern uint CardType { [MethodImpl] get; }

    /// <summary>Gets the track data for Track 1.</summary>
    /// <returns>The Track 1 data.</returns>
    public extern MagneticStripeReaderTrackData Track1 { [MethodImpl] get; }

    /// <summary>Gets the track data for Track 2.</summary>
    /// <returns>The Track 3 data.</returns>
    public extern MagneticStripeReaderTrackData Track2 { [MethodImpl] get; }

    /// <summary>Gets the track data for Track 3.</summary>
    /// <returns>The Track 3 data.</returns>
    public extern MagneticStripeReaderTrackData Track3 { [MethodImpl] get; }

    /// <summary>Gets the track data for Track 4.</summary>
    /// <returns>The Track 4 data.</returns>
    public extern MagneticStripeReaderTrackData Track4 { [MethodImpl] get; }

    /// <summary>Gets a dictionary of properties for the recently swiped card.</summary>
    /// <returns>A dictionary of properties.</returns>
    public extern IMapView<string, string> Properties { [MethodImpl] get; }

    /// <summary>Gets the card authentication information for the recently swiped card.</summary>
    /// <returns>The card authentication data.</returns>
    public extern IBuffer CardAuthenticationData { [MethodImpl] get; }

    /// <summary>Gets the length of the raw CardAuthenticationData before it is encrypted.</summary>
    /// <returns>The length of the raw CardAuthenticationData before it is encrypted.</returns>
    public extern uint CardAuthenticationDataLength { [MethodImpl] get; }

    /// <summary>Gets the additional security or encryption information for the recently swiped card.</summary>
    /// <returns>The additional security or encryption information.</returns>
    public extern IBuffer AdditionalSecurityInformation { [MethodImpl] get; }
  }
}
