// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextHighlighter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (TextHighlighter))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3127686475, 32117, 17717, 179, 13, 168, 26, 0, 182, 55, 164)]
  [WebHostHidden]
  internal interface ITextHighlighter
  {
    IVector<TextRange> Ranges { get; }

    Brush Foreground { get; set; }

    Brush Background { get; set; }
  }
}
