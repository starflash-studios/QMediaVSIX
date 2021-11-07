// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringManagerStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(3015309776, 60415, 18084, 168, 71, 214, 99, 216, 176, 151, 126)]
  [ExclusiveTo(typeof (NetworkOperatorTetheringManager))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface INetworkOperatorTetheringManagerStatics4
  {
    bool IsNoConnectionsTimeoutEnabled();

    void EnableNoConnectionsTimeout();

    [RemoteAsync]
    IAsyncAction EnableNoConnectionsTimeoutAsync();

    void DisableNoConnectionsTimeout();

    [RemoteAsync]
    IAsyncAction DisableNoConnectionsTimeoutAsync();
  }
}
