// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IESimProfileMetadata
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  [Guid(3978658591, 37083, 18829, 167, 180, 235, 206, 128, 125, 60, 35)]
  [ExclusiveTo(typeof (ESimProfileMetadata))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IESimProfileMetadata
  {
    bool IsConfirmationCodeRequired { get; }

    ESimProfilePolicy Policy { get; }

    string Id { get; }

    IRandomAccessStreamReference ProviderIcon { get; }

    string ProviderId { get; }

    string ProviderName { get; }

    ESimProfileMetadataState State { get; }

    [RemoteAsync]
    IAsyncOperation<ESimOperationResult> DenyInstallAsync();

    [Overload("ConfirmInstallAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<ESimOperationResult, ESimProfileInstallProgress> ConfirmInstallAsync();

    [Overload("ConfirmInstallWithConfirmationCodeAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<ESimOperationResult, ESimProfileInstallProgress> ConfirmInstallAsync(
      string confirmationCode);

    [RemoteAsync]
    IAsyncOperation<ESimOperationResult> PostponeInstallAsync();

    event TypedEventHandler<ESimProfileMetadata, object> StateChanged;
  }
}
