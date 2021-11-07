// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystem5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3945453347, 58850, 19170, 167, 167, 161, 9, 122, 9, 142, 144)]
  [ExclusiveTo(typeof (RemoteSystem))]
  internal interface IRemoteSystem5
  {
    IVectorView<RemoteSystemApp> Apps { get; }
  }
}
