// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionMessageChannelFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(694033482, 48406, 17048, 183, 206, 65, 84, 130, 176, 225, 29)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (RemoteSystemSessionMessageChannel))]
  internal interface IRemoteSystemSessionMessageChannelFactory
  {
    [Overload("Create")]
    RemoteSystemSessionMessageChannel Create(
      RemoteSystemSession session,
      string channelName);

    [Overload("CreateWithReliability")]
    RemoteSystemSessionMessageChannel Create(
      RemoteSystemSession session,
      string channelName,
      RemoteSystemSessionMessageChannelReliability reliability);
  }
}
