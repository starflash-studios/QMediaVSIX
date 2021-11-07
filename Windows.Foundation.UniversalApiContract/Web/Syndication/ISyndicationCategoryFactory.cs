// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationCategoryFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2873262127, 18912, 17701, 138, 178, 171, 69, 192, 37, 40, 255)]
  [ExclusiveTo(typeof (SyndicationCategory))]
  internal interface ISyndicationCategoryFactory
  {
    SyndicationCategory CreateSyndicationCategory(string term);

    SyndicationCategory CreateSyndicationCategoryEx(
      string term,
      string scheme,
      string label);
  }
}
