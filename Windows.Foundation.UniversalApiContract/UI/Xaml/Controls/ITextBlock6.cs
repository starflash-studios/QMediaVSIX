// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBlock6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Documents;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextBlock))]
  [WebHostHidden]
  [Guid(830565593, 1028, 16655, 145, 236, 51, 176, 160, 187, 146, 178)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ITextBlock6
  {
    bool IsTextTrimmed { get; }

    TextAlignment HorizontalTextAlignment { get; set; }

    IVector<TextHighlighter> TextHighlighters { get; }

    event TypedEventHandler<TextBlock, IsTextTrimmedChangedEventArgs> IsTextTrimmedChanged;
  }
}
