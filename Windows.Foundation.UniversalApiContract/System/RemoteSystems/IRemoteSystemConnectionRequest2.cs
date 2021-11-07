// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemConnectionRequest2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(316632431, 49148, 18490, 138, 190, 211, 74, 108, 25, 249, 43)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (RemoteSystemConnectionRequest))]
  internal interface IRemoteSystemConnectionRequest2
  {
    RemoteSystemApp RemoteSystemApp { get; }
  }
}
