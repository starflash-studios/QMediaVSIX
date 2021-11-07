// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationGeneratorFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Guid(2738914275, 7718, 19900, 186, 157, 26, 184, 75, 239, 249, 123)]
  [ExclusiveTo(typeof (SyndicationGenerator))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationGeneratorFactory
  {
    SyndicationGenerator CreateSyndicationGenerator(string text);
  }
}
