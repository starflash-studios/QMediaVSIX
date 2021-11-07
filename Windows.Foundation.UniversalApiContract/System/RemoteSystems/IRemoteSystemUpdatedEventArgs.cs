// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemUpdatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemUpdatedEventArgs))]
  [Guid(1963130638, 56267, 16725, 180, 202, 179, 10, 4, 242, 118, 39)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRemoteSystemUpdatedEventArgs
  {
    RemoteSystem RemoteSystem { get; }
  }
}
