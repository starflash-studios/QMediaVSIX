// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemWebAccountFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1068980339, 34760, 23951, 151, 126, 246, 159, 150, 214, 114, 56)]
  [ExclusiveTo(typeof (RemoteSystemWebAccountFilter))]
  internal interface IRemoteSystemWebAccountFilter
  {
    WebAccount Account { get; }
  }
}
