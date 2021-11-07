// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemKindFilterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(2717587694, 39402, 16572, 154, 57, 198, 112, 170, 128, 74, 40)]
  [ExclusiveTo(typeof (RemoteSystemKindFilter))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRemoteSystemKindFilterFactory
  {
    RemoteSystemKindFilter Create(IIterable<string> remoteSystemKinds);
  }
}
