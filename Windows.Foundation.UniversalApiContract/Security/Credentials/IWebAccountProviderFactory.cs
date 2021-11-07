// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IWebAccountProviderFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  [ExclusiveTo(typeof (WebAccountProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(494304753, 57825, 19354, 167, 116, 92, 124, 126, 59, 243, 113)]
  internal interface IWebAccountProviderFactory
  {
    WebAccountProvider CreateWebAccountProvider(
      string id,
      string displayName,
      Uri iconUri);
  }
}
