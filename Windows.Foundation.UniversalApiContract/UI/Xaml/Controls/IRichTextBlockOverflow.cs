// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlockOverflow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Documents;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1335063707, 56003, 19010, 156, 187, 153, 240, 222, 55, 192, 113)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RichTextBlockOverflow))]
  internal interface IRichTextBlockOverflow
  {
    RichTextBlockOverflow OverflowContentTarget { get; set; }

    Thickness Padding { get; set; }

    RichTextBlock ContentSource { get; }

    bool HasOverflowContent { get; }

    TextPointer ContentStart { get; }

    TextPointer ContentEnd { get; }

    double BaselineOffset { get; }

    TextPointer GetPositionFromPoint(Point point);

    bool Focus(FocusState value);
  }
}
