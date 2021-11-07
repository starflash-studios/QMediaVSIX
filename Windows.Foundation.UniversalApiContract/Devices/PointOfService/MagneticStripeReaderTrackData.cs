// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReaderTrackData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  /// <summary>Contains the track data obtained following a card swipe.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MagneticStripeReaderTrackData : IMagneticStripeReaderTrackData
  {
    /// <summary>Gets the raw or decoded data from the swiped card.</summary>
    /// <returns>The track data from the swiped card.</returns>
    public extern IBuffer Data { [MethodImpl] get; }

    /// <summary>Gets the discretionary data from the swiped card.</summary>
    /// <returns>The discretionary data from the swiped card.</returns>
    public extern IBuffer DiscretionaryData { [MethodImpl] get; }

    /// <summary>Gets the encrypted data from the swiped card.</summary>
    /// <returns>The encrypted data from the swiped card.</returns>
    public extern IBuffer EncryptedData { [MethodImpl] get; }
  }
}
