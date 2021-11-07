// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IApplicationView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ApplicationView))]
  [Guid(3525498137, 17249, 17694, 150, 196, 96, 244, 249, 116, 45, 176)]
  internal interface IApplicationView
  {
    ApplicationViewOrientation Orientation { get; }

    bool AdjacentToLeftDisplayEdge { get; }

    bool AdjacentToRightDisplayEdge { get; }

    bool IsFullScreen { [Deprecated("To check full screen mode, use IsFullScreenMode. To check if the view is adjacent to both edges, use AdjacentToLeftDisplayEdge and AdjacentToRightDisplayEdge. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    bool IsOnLockScreen { get; }

    bool IsScreenCaptureEnabled { get; set; }

    string Title { set; get; }

    int Id { get; }

    event TypedEventHandler<ApplicationView, ApplicationViewConsolidatedEventArgs> Consolidated;
  }
}
