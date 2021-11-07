// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionParticipantAddedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemSessionParticipantAddedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3545913304, 51617, 19383, 182, 176, 121, 187, 145, 173, 249, 61)]
  internal interface IRemoteSystemSessionParticipantAddedEventArgs
  {
    RemoteSystemSessionParticipant Participant { get; }
  }
}
