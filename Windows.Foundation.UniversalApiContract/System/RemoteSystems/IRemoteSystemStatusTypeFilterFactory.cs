// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemStatusTypeFilterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemStatusTypeFilter))]
  [Guid(869234938, 55076, 16677, 172, 122, 141, 40, 30, 68, 201, 73)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRemoteSystemStatusTypeFilterFactory
  {
    RemoteSystemStatusTypeFilter Create(
      RemoteSystemStatusType remoteSystemStatusType);
  }
}
