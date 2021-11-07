// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemAddedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(2402899471, 58676, 18071, 136, 54, 122, 190, 161, 81, 81, 110)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RemoteSystemAddedEventArgs))]
  internal interface IRemoteSystemAddedEventArgs
  {
    RemoteSystem RemoteSystem { get; }
  }
}
