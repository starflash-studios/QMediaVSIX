// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationLinkFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Guid(1591239636, 21813, 18604, 152, 212, 193, 144, 153, 80, 128, 179)]
  [ExclusiveTo(typeof (SyndicationLink))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationLinkFactory
  {
    SyndicationLink CreateSyndicationLink(Uri uri);

    SyndicationLink CreateSyndicationLinkEx(
      Uri uri,
      string relationship,
      string title,
      string mediaType,
      uint length);
  }
}
