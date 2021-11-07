// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionParticipant
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.System.RemoteSystems
{
  [Guid(2123367820, 44281, 18217, 138, 23, 68, 231, 186, 237, 93, 204)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (RemoteSystemSessionParticipant))]
  internal interface IRemoteSystemSessionParticipant
  {
    RemoteSystem RemoteSystem { get; }

    IVectorView<HostName> GetHostNames();
  }
}
