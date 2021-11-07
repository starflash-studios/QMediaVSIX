// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationFeed
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2147368146, 23398, 19810, 132, 3, 27, 193, 13, 145, 13, 107)]
  [ExclusiveTo(typeof (SyndicationFeed))]
  internal interface ISyndicationFeed : ISyndicationNode
  {
    IVector<SyndicationPerson> Authors { get; }

    IVector<SyndicationCategory> Categories { get; }

    IVector<SyndicationPerson> Contributors { get; }

    SyndicationGenerator Generator { get; set; }

    Uri IconUri { get; set; }

    string Id { get; set; }

    IVector<SyndicationItem> Items { get; }

    DateTime LastUpdatedTime { get; set; }

    IVector<SyndicationLink> Links { get; }

    Uri ImageUri { get; set; }

    ISyndicationText Rights { get; set; }

    ISyndicationText Subtitle { get; set; }

    ISyndicationText Title { get; set; }

    Uri FirstUri { get; }

    Uri LastUri { get; }

    Uri NextUri { get; }

    Uri PreviousUri { get; }

    SyndicationFormat SourceFormat { get; }

    void Load(string feed);

    void LoadFromXml(XmlDocument feedDocument);
  }
}
