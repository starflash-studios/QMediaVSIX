// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ExclusiveTo(typeof (SyndicationItem))]
  [Guid(1418573955, 50052, 17857, 138, 232, 163, 120, 196, 236, 72, 108)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationItem : ISyndicationNode
  {
    IVector<SyndicationPerson> Authors { get; }

    IVector<SyndicationCategory> Categories { get; }

    IVector<SyndicationPerson> Contributors { get; }

    SyndicationContent Content { get; set; }

    string Id { get; set; }

    DateTime LastUpdatedTime { get; set; }

    IVector<SyndicationLink> Links { get; }

    DateTime PublishedDate { get; set; }

    ISyndicationText Rights { get; set; }

    SyndicationFeed Source { get; set; }

    ISyndicationText Summary { get; set; }

    ISyndicationText Title { get; set; }

    Uri CommentsUri { get; set; }

    Uri EditUri { get; }

    Uri EditMediaUri { get; }

    string ETag { get; }

    Uri ItemUri { get; }

    void Load(string item);

    void LoadFromXml(XmlDocument itemDocument);
  }
}
