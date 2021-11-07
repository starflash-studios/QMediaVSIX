// Decompiled with JetBrains decompiler
// Type: Windows.Web.AtomPub.IAtomPubClientFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Web.AtomPub
{
  [Guid(1238716434, 22475, 19422, 171, 159, 38, 16, 177, 114, 119, 123)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AtomPubClient))]
  internal interface IAtomPubClientFactory
  {
    AtomPubClient CreateAtomPubClientWithCredentials(
      PasswordCredential serverCredential);
  }
}
