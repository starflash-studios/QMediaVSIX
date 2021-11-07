// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlockOverflow3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2137610363, 23679, 19295, 189, 188, 251, 149, 201, 14, 16, 222)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (RichTextBlockOverflow))]
  internal interface IRichTextBlockOverflow3
  {
    bool IsTextTrimmed { get; }

    event TypedEventHandler<RichTextBlockOverflow, IsTextTrimmedChangedEventArgs> IsTextTrimmedChanged;
  }
}
