// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichEditBoxStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1264338280, 17365, 17382, 187, 185, 203, 78, 98, 80, 244, 90)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (RichEditBox))]
  internal interface IRichEditBoxStatics5
  {
    DependencyProperty SelectionHighlightColorWhenNotFocusedProperty { get; }

    DependencyProperty MaxLengthProperty { get; }
  }
}
