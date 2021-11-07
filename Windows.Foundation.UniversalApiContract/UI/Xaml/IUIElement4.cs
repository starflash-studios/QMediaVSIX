// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElement4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml
{
  [Guid(1762942164, 6554, 18007, 158, 87, 233, 158, 143, 19, 103, 18)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (UIElement))]
  [WebHostHidden]
  internal interface IUIElement4
  {
    FlyoutBase ContextFlyout { get; set; }

    bool ExitDisplayModeOnAccessKeyInvoked { get; set; }

    bool IsAccessKeyScope { get; set; }

    DependencyObject AccessKeyScopeOwner { get; set; }

    string AccessKey { get; set; }

    event TypedEventHandler<UIElement, ContextRequestedEventArgs> ContextRequested;

    event TypedEventHandler<UIElement, RoutedEventArgs> ContextCanceled;

    event TypedEventHandler<UIElement, AccessKeyDisplayRequestedEventArgs> AccessKeyDisplayRequested;

    event TypedEventHandler<UIElement, AccessKeyDisplayDismissedEventArgs> AccessKeyDisplayDismissed;

    event TypedEventHandler<UIElement, AccessKeyInvokedEventArgs> AccessKeyInvoked;
  }
}
