// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionInvitationReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemSessionInvitationReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1586907693, 41229, 20187, 141, 234, 84, 210, 10, 193, 149, 67)]
  internal interface IRemoteSystemSessionInvitationReceivedEventArgs
  {
    RemoteSystemSessionInvitation Invitation { get; }
  }
}
