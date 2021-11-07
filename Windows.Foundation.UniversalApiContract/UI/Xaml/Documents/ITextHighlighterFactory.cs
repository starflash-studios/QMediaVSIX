// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextHighlighterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Guid(1880249441, 39567, 20384, 178, 53, 143, 250, 165, 7, 190, 242)]
  [ExclusiveTo(typeof (TextHighlighter))]
  internal interface ITextHighlighterFactory
  {
    TextHighlighter CreateInstance(object baseInterface, out object innerInterface);
  }
}
