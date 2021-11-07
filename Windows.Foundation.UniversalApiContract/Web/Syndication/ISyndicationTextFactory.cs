// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationTextFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Guid(4000531191, 4550, 19237, 171, 98, 229, 150, 189, 22, 41, 70)]
  [ExclusiveTo(typeof (SyndicationText))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationTextFactory
  {
    SyndicationText CreateSyndicationText(string text);

    SyndicationText CreateSyndicationTextEx(string text, SyndicationTextType type);
  }
}
