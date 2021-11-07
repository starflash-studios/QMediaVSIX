// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemApp2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemApp))]
  [Guid(1667874581, 2710, 22394, 143, 246, 195, 89, 4, 223, 168, 243)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IRemoteSystemApp2
  {
    User User { get; }

    string ConnectionToken { get; }
  }
}
