// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (NetworkOperatorTetheringManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3562704288, 3718, 19864, 139, 164, 221, 112, 212, 183, 100, 211)]
  internal interface INetworkOperatorTetheringManager
  {
    uint MaxClientCount { get; }

    uint ClientCount { get; }

    TetheringOperationalState TetheringOperationalState { get; }

    NetworkOperatorTetheringAccessPointConfiguration GetCurrentAccessPointConfiguration();

    IAsyncAction ConfigureAccessPointAsync(
      NetworkOperatorTetheringAccessPointConfiguration configuration);

    [RemoteAsync]
    IAsyncOperation<NetworkOperatorTetheringOperationResult> StartTetheringAsync();

    [RemoteAsync]
    IAsyncOperation<NetworkOperatorTetheringOperationResult> StopTetheringAsync();
  }
}
