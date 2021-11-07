// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IESimProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (ESimProfile))]
  [Guid(3994974336, 1705, 16423, 180, 248, 221, 178, 61, 120, 16, 224)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IESimProfile
  {
    ESimProfileClass Class { get; }

    string Nickname { get; }

    ESimProfilePolicy Policy { get; }

    string Id { get; }

    IRandomAccessStreamReference ProviderIcon { get; }

    string ProviderId { get; }

    string ProviderName { get; }

    ESimProfileState State { get; }

    [RemoteAsync]
    IAsyncOperation<ESimOperationResult> DisableAsync();

    [RemoteAsync]
    IAsyncOperation<ESimOperationResult> EnableAsync();

    [RemoteAsync]
    IAsyncOperation<ESimOperationResult> SetNicknameAsync(
      string newNickname);
  }
}
