// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemStatusTypeFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(205082958, 52150, 18295, 133, 52, 46, 12, 82, 26, 255, 162)]
  [ExclusiveTo(typeof (RemoteSystemStatusTypeFilter))]
  internal interface IRemoteSystemStatusTypeFilter
  {
    RemoteSystemStatusType RemoteSystemStatusType { get; }
  }
}
