// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionCreationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(2811761346, 14302, 17548, 139, 131, 163, 10, 163, 196, 234, 214)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (RemoteSystemSessionCreationResult))]
  internal interface IRemoteSystemSessionCreationResult
  {
    RemoteSystemSessionCreationStatus Status { get; }

    RemoteSystemSession Session { get; }
  }
}
