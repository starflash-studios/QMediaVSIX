// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationContent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Guid(1178730238, 3669, 16592, 184, 208, 106, 44, 203, 169, 252, 124)]
  [ExclusiveTo(typeof (SyndicationContent))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationContent : ISyndicationText, ISyndicationNode
  {
    Uri SourceUri { get; set; }
  }
}
