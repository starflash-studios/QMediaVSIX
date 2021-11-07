// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountClientView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  [Guid(3887949498, 3015, 19558, 191, 212, 101, 211, 8, 44, 188, 168)]
  [ExclusiveTo(typeof (WebAccountClientView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAccountClientView
  {
    Uri ApplicationCallbackUri { get; }

    WebAccountClientViewType Type { get; }

    string AccountPairwiseId { get; }
  }
}
