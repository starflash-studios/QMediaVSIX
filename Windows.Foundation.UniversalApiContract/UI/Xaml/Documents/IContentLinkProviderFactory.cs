// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IContentLinkProviderFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [Guid(1473645883, 61210, 20110, 131, 155, 211, 110, 243, 165, 3, 224)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (ContentLinkProvider))]
  internal interface IContentLinkProviderFactory
  {
    ContentLinkProvider CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
