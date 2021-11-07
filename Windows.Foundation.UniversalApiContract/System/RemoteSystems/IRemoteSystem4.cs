// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystem4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(4049928165, 47495, 19621, 153, 38, 250, 4, 56, 190, 98, 115)]
  [ExclusiveTo(typeof (RemoteSystem))]
  internal interface IRemoteSystem4
  {
    RemoteSystemPlatform Platform { get; }
  }
}
