// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountClientViewFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1634539172, 56866, 18517, 163, 38, 6, 206, 191, 42, 63, 35)]
  [ExclusiveTo(typeof (WebAccountClientView))]
  internal interface IWebAccountClientViewFactory
  {
    WebAccountClientView Create(
      WebAccountClientViewType viewType,
      Uri applicationCallbackUri);

    WebAccountClientView CreateWithPairwiseId(
      WebAccountClientViewType viewType,
      Uri applicationCallbackUri,
      string accountPairwiseId);
  }
}
