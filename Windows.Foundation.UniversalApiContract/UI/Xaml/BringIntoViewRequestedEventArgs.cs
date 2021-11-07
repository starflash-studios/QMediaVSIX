// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.BringIntoViewRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides data for the UIElement.BringIntoViewRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BringIntoViewRequestedEventArgs : 
    RoutedEventArgs,
    IBringIntoViewRequestedEventArgs
  {
    /// <summary>Gets or sets the element that should be made visible in response to the event.</summary>
    /// <returns>The element that should be made visible in response to the event.</returns>
    public extern UIElement TargetElement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the scrolling should be animated.</summary>
    /// <returns>**true** to animate the scrolling; otherwise, **false**.</returns>
    public extern bool AnimationDesired { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Rect in the TargetElement’s coordinate space to bring into view.</summary>
    /// <returns>The Rect in the TargetElement’s coordinate space to bring into view.</returns>
    public extern Rect TargetRect { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the requested horizontal alignment ratio which controls the alignment of the vertical axis of the TargetRect with respect to the vertical axis of the viewport.</summary>
    /// <returns>The requested horizontal alignment ratio between 0.0 and 1.0, or NaN. See Remarks.</returns>
    public extern double HorizontalAlignmentRatio { [MethodImpl] get; }

    /// <summary>Gets the requested vertical alignment ratio which controls the alignment of the horizontal axis of the TargetRect with respect to the horizontal axis of the viewport.</summary>
    /// <returns>The requested vertical alignment ratio between 0.0 and 1.0, or NaN. See Remarks.</returns>
    public extern double VerticalAlignmentRatio { [MethodImpl] get; }

    /// <summary>Gets or sets the horizontal distance to add to the viewport-relative position of the TargetRect after satisfying the requested HorizontalAlignmentRatio.</summary>
    /// <returns>The horizontal distance to add to the viewport-relative position of the TargetRect after satisfying the requested HorizontalAlignmentRatio.</returns>
    public extern double HorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the vertical distance to add to the viewport-relative position of the TargetRect after satisfying the requested VerticalAlignmentRatio.</summary>
    /// <returns>The vertical distance to add to the viewport-relative position of the TargetRect after satisfying the requested VerticalAlignmentRatio.</returns>
    public extern double VerticalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that marks the routed event as handled. A **true** value prevents most handlers along the event route from handling the same event again.</summary>
    /// <returns>**true** to mark the routed event handled. **false** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
