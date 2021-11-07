// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationLink
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ExclusiveTo(typeof (SyndicationLink))]
  [Guid(659897021, 41230, 16821, 134, 189, 151, 89, 8, 110, 176, 197)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationLink : ISyndicationNode
  {
    uint Length { get; set; }

    string MediaType { get; set; }

    string Relationship { get; set; }

    string Title { get; set; }

    Uri Uri { get; set; }

    string ResourceLanguage { get; set; }
  }
}
