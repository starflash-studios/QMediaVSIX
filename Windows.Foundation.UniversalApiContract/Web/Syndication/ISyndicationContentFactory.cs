// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationContentFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ExclusiveTo(typeof (SyndicationContent))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1026538387, 38176, 16755, 147, 136, 126, 45, 243, 36, 168, 160)]
  internal interface ISyndicationContentFactory
  {
    SyndicationContent CreateSyndicationContent(
      string text,
      SyndicationTextType type);

    SyndicationContent CreateSyndicationContentWithSourceUri(Uri sourceUri);
  }
}
