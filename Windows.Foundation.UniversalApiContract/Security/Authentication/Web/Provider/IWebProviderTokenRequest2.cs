// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebProviderTokenRequest2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Authentication.Web.Provider
{
  [ExclusiveTo(typeof (WebProviderTokenRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3050778188, 4273, 19110, 136, 177, 11, 108, 158, 12, 30, 70)]
  internal interface IWebProviderTokenRequest2
  {
    [RemoteAsync]
    IAsyncOperation<IBuffer> GetApplicationTokenBindingKeyIdAsync(
      TokenBindingKeyType keyType,
      Uri target);
  }
}
