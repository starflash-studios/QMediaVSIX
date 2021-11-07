// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialog2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ContentDialog))]
  [Guid(798223173, 60995, 17155, 155, 56, 63, 225, 161, 17, 236, 191)]
  internal interface IContentDialog2
  {
    string CloseButtonText { get; set; }

    ICommand CloseButtonCommand { get; set; }

    object CloseButtonCommandParameter { get; set; }

    Style PrimaryButtonStyle { get; set; }

    Style SecondaryButtonStyle { get; set; }

    Style CloseButtonStyle { get; set; }

    ContentDialogButton DefaultButton { get; set; }

    event TypedEventHandler<ContentDialog, ContentDialogButtonClickEventArgs> CloseButtonClick;
  }
}
