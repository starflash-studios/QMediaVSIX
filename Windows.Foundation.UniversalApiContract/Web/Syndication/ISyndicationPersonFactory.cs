// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationPersonFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ExclusiveTo(typeof (SyndicationPerson))]
  [Guid(3707013229, 8861, 19288, 164, 155, 243, 210, 240, 245, 201, 159)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationPersonFactory
  {
    SyndicationPerson CreateSyndicationPerson(string name);

    SyndicationPerson CreateSyndicationPersonEx(
      string name,
      string email,
      Uri uri);
  }
}
