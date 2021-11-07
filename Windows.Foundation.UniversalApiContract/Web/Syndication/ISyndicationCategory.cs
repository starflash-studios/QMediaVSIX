// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationCategory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Guid(2266325615, 3258, 19071, 137, 255, 236, 181, 40, 20, 35, 182)]
  [ExclusiveTo(typeof (SyndicationCategory))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationCategory : ISyndicationNode
  {
    string Label { get; set; }

    string Scheme { get; set; }

    string Term { get; set; }
  }
}
