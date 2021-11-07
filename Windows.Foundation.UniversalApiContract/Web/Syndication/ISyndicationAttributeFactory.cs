// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationAttributeFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [ExclusiveTo(typeof (SyndicationAttribute))]
  [Guid(1649350041, 60734, 16911, 190, 134, 100, 4, 20, 136, 110, 75)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationAttributeFactory
  {
    SyndicationAttribute CreateSyndicationAttribute(
      string attributeName,
      string attributeNamespace,
      string attributeValue);
  }
}
