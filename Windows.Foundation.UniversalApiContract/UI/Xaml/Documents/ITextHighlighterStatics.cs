// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextHighlighterStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [Guid(3014658500, 14974, 18892, 171, 132, 41, 196, 5, 72, 135, 101)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TextHighlighter))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ITextHighlighterStatics
  {
    DependencyProperty ForegroundProperty { get; }

    DependencyProperty BackgroundProperty { get; }
  }
}
