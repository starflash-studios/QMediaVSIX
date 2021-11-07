// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderDeleteAccountOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Provider
{
  [Guid(180046008, 40449, 18889, 163, 85, 125, 72, 202, 247, 214, 202)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebAccountProviderDeleteAccountOperation))]
  internal interface IWebAccountProviderDeleteAccountOperation : IWebAccountProviderOperation
  {
    WebAccount WebAccount { get; }
  }
}
