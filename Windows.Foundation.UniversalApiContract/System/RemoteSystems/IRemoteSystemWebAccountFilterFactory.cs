// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemWebAccountFilterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (RemoteSystemWebAccountFilter))]
  [Guid(881469193, 24397, 20775, 180, 167, 191, 153, 213, 37, 43, 27)]
  internal interface IRemoteSystemWebAccountFilterFactory
  {
    RemoteSystemWebAccountFilter Create(WebAccount account);
  }
}
