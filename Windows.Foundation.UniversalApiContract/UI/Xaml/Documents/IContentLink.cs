// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IContentLink
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;
using Windows.UI.Text;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Documents
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [Guid(1818280929, 21132, 17144, 146, 190, 52, 184, 198, 139, 227, 4)]
  [ExclusiveTo(typeof (ContentLink))]
  internal interface IContentLink
  {
    ContentLinkInfo Info { get; set; }

    Brush Background { get; set; }

    CoreCursorType Cursor { get; set; }

    DependencyObject XYFocusLeft { get; set; }

    DependencyObject XYFocusRight { get; set; }

    DependencyObject XYFocusUp { get; set; }

    DependencyObject XYFocusDown { get; set; }

    ElementSoundMode ElementSoundMode { get; set; }

    FocusState FocusState { get; }

    XYFocusNavigationStrategy XYFocusUpNavigationStrategy { get; set; }

    XYFocusNavigationStrategy XYFocusDownNavigationStrategy { get; set; }

    XYFocusNavigationStrategy XYFocusLeftNavigationStrategy { get; set; }

    XYFocusNavigationStrategy XYFocusRightNavigationStrategy { get; set; }

    bool IsTabStop { get; set; }

    int TabIndex { get; set; }

    event TypedEventHandler<ContentLink, ContentLinkInvokedEventArgs> Invoked;

    event RoutedEventHandler GotFocus;

    event RoutedEventHandler LostFocus;

    bool Focus(FocusState value);
  }
}
