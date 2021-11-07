// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IESim
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (ESim))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1869508134, 61731, 17277, 140, 237, 220, 29, 43, 192, 195, 169)]
  internal interface IESim
  {
    IReference<int> AvailableMemoryInBytes { get; }

    string Eid { get; }

    string FirmwareVersion { get; }

    string MobileBroadbandModemDeviceId { get; }

    ESimPolicy Policy { get; }

    ESimState State { get; }

    IVectorView<ESimProfile> GetProfiles();

    [RemoteAsync]
    IAsyncOperation<ESimOperationResult> DeleteProfileAsync(
      string profileId);

    [RemoteAsync]
    IAsyncOperation<ESimDownloadProfileMetadataResult> DownloadProfileMetadataAsync(
      string activationCode);

    [RemoteAsync]
    IAsyncOperation<ESimOperationResult> ResetAsync();

    event TypedEventHandler<ESim, object> ProfileChanged;
  }
}
