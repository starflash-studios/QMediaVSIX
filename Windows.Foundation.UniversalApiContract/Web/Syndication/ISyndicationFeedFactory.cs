// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationFeedFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ExclusiveTo(typeof (SyndicationFeed))]
  [Guid(591864370, 35817, 18615, 137, 52, 98, 5, 19, 29, 147, 87)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationFeedFactory
  {
    SyndicationFeed CreateSyndicationFeed(string title, string subtitle, Uri uri);
  }
}
