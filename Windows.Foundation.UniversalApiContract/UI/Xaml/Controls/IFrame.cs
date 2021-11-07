// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Frame))]
  [WebHostHidden]
  [Guid(1760186379, 16361, 18229, 182, 160, 231, 96, 25, 51, 176, 137)]
  internal interface IFrame
  {
    int CacheSize { get; set; }

    bool CanGoBack { get; }

    bool CanGoForward { get; }

    TypeName CurrentSourcePageType { get; }

    TypeName SourcePageType { get; set; }

    int BackStackDepth { get; }

    event NavigatedEventHandler Navigated;

    event NavigatingCancelEventHandler Navigating;

    event NavigationFailedEventHandler NavigationFailed;

    event NavigationStoppedEventHandler NavigationStopped;

    void GoBack();

    void GoForward();

    bool Navigate(TypeName sourcePageType, object parameter);

    string GetNavigationState();

    [Overload("SetNavigationState")]
    void SetNavigationState(string navigationState);
  }
}
