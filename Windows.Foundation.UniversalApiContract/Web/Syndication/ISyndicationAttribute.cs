// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.ISyndicationAttribute
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  [Guid(1911093609, 21102, 16385, 154, 145, 232, 79, 131, 22, 26, 177)]
  [ExclusiveTo(typeof (SyndicationAttribute))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISyndicationAttribute
  {
    string Name { get; set; }

    string Namespace { get; set; }

    string Value { get; set; }
  }
}
