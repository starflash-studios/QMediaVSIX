// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemAuthorizationKindFilterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemAuthorizationKindFilter))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2909134669, 46698, 17828, 129, 119, 140, 174, 215, 93, 158, 90)]
  internal interface IRemoteSystemAuthorizationKindFilterFactory
  {
    RemoteSystemAuthorizationKindFilter Create(
      RemoteSystemAuthorizationKind remoteSystemAuthorizationKind);
  }
}
