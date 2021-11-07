// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlock5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Documents;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2625487046, 31391, 17846, 136, 24, 130, 44, 84, 155, 160, 148)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (RichTextBlock))]
  [WebHostHidden]
  internal interface IRichTextBlock5
  {
    bool IsTextTrimmed { get; }

    TextAlignment HorizontalTextAlignment { get; set; }

    IVector<TextHighlighter> TextHighlighters { get; }

    event TypedEventHandler<RichTextBlock, IsTextTrimmedChangedEventArgs> IsTextTrimmedChanged;
  }
}
