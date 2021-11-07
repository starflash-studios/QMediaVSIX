// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemConnectionRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemConnectionRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2230141188, 36190, 19826, 130, 56, 118, 33, 87, 108, 122, 103)]
  internal interface IRemoteSystemConnectionRequest
  {
    RemoteSystem RemoteSystem { get; }
  }
}
