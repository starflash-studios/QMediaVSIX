// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationView2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Guid(3900092822, 42309, 16604, 181, 148, 69, 12, 186, 104, 204, 0)]
  [ExclusiveTo(typeof (ApplicationView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IApplicationView2
  {
    bool SuppressSystemOverlays { [Deprecated("Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    Rect VisibleBounds { get; }

    event TypedEventHandler<ApplicationView, object> VisibleBoundsChanged;

    bool SetDesiredBoundsMode(ApplicationViewBoundsMode boundsMode);

    ApplicationViewBoundsMode DesiredBoundsMode { get; }
  }
}
