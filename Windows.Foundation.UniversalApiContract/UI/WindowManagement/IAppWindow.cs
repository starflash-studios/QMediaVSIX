// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.IAppWindow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.WindowManagement
{
  [ExclusiveTo(typeof (AppWindow))]
  [Guid(1714427046, 46942, 23997, 153, 92, 240, 17, 127, 163, 251, 97)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IAppWindow
  {
    UIContentRoot Content { get; }

    DispatcherQueue DispatcherQueue { get; }

    AppWindowFrame Frame { get; }

    bool IsVisible { get; }

    string PersistedStateId { get; set; }

    AppWindowPresenter Presenter { get; }

    string Title { get; set; }

    AppWindowTitleBar TitleBar { get; }

    UIContext UIContext { get; }

    WindowingEnvironment WindowingEnvironment { get; }

    [RemoteAsync]
    IAsyncAction CloseAsync();

    AppWindowPlacement GetPlacement();

    IVectorView<DisplayRegion> GetDisplayRegions();

    void RequestMoveToDisplayRegion(DisplayRegion displayRegion);

    void RequestMoveAdjacentToCurrentView();

    void RequestMoveAdjacentToWindow(AppWindow anchorWindow);

    void RequestMoveRelativeToWindowContent(AppWindow anchorWindow, Point contentOffset);

    void RequestMoveRelativeToCurrentViewContent(Point contentOffset);

    void RequestMoveRelativeToDisplayRegion(DisplayRegion displayRegion, Point displayRegionOffset);

    void RequestSize(Size frameSize);

    [RemoteAsync]
    IAsyncOperation<bool> TryShowAsync();

    event TypedEventHandler<AppWindow, AppWindowChangedEventArgs> Changed;

    event TypedEventHandler<AppWindow, AppWindowClosedEventArgs> Closed;

    event TypedEventHandler<AppWindow, AppWindowCloseRequestedEventArgs> CloseRequested;
  }
}
