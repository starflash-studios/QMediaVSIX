// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (RemoteSystemSessionInfo))]
  [Guid(4283299400, 35594, 20122, 153, 5, 105, 228, 184, 65, 197, 136)]
  internal interface IRemoteSystemSessionInfo
  {
    string DisplayName { get; }

    string ControllerDisplayName { get; }

    [RemoteAsync]
    IAsyncOperation<RemoteSystemSessionJoinResult> JoinAsync();
  }
}
