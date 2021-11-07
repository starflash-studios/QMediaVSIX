// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemKindFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(954321388, 8899, 20214, 144, 26, 187, 177, 199, 170, 212, 237)]
  [ExclusiveTo(typeof (RemoteSystemKindFilter))]
  internal interface IRemoteSystemKindFilter
  {
    IVectorView<string> RemoteSystemKinds { get; }
  }
}
