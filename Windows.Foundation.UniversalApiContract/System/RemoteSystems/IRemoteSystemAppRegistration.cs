// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemAppRegistration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(3027847093, 28725, 19034, 184, 223, 150, 45, 143, 132, 49, 244)]
  [ExclusiveTo(typeof (RemoteSystemAppRegistration))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IRemoteSystemAppRegistration
  {
    User User { get; }

    IMap<string, string> Attributes { get; }

    [RemoteAsync]
    IAsyncOperation<bool> SaveAsync();
  }
}
