// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationClientFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Web.Syndication
{
  [ExclusiveTo(typeof (SyndicationClient))]
  [Guid(784642860, 42907, 16660, 178, 154, 5, 223, 251, 175, 185, 164)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationClientFactory
  {
    SyndicationClient CreateSyndicationClient(PasswordCredential serverCredential);
  }
}
