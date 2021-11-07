// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlockStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2895283105, 20261, 17024, 136, 104, 62, 238, 232, 40, 33, 232)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RichTextBlock))]
  internal interface IRichTextBlockStatics5
  {
    DependencyProperty IsTextTrimmedProperty { get; }

    DependencyProperty HorizontalTextAlignmentProperty { get; }
  }
}
