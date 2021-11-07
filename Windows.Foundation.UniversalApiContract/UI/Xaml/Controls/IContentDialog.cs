// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialog
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ContentDialog))]
  [WebHostHidden]
  [Guid(953959428, 53838, 16600, 148, 21, 52, 148, 100, 193, 175, 220)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContentDialog
  {
    object Title { get; set; }

    DataTemplate TitleTemplate { get; set; }

    bool FullSizeDesired { get; set; }

    string PrimaryButtonText { get; set; }

    string SecondaryButtonText { get; set; }

    ICommand PrimaryButtonCommand { get; set; }

    ICommand SecondaryButtonCommand { get; set; }

    object PrimaryButtonCommandParameter { get; set; }

    object SecondaryButtonCommandParameter { get; set; }

    bool IsPrimaryButtonEnabled { get; set; }

    bool IsSecondaryButtonEnabled { get; set; }

    event TypedEventHandler<ContentDialog, ContentDialogClosingEventArgs> Closing;

    event TypedEventHandler<ContentDialog, ContentDialogClosedEventArgs> Closed;

    event TypedEventHandler<ContentDialog, ContentDialogOpenedEventArgs> Opened;

    event TypedEventHandler<ContentDialog, ContentDialogButtonClickEventArgs> PrimaryButtonClick;

    event TypedEventHandler<ContentDialog, ContentDialogButtonClickEventArgs> SecondaryButtonClick;

    void Hide();

    [RemoteAsync]
    [Overload("ShowAsync")]
    IAsyncOperation<ContentDialogResult> ShowAsync();
  }
}
