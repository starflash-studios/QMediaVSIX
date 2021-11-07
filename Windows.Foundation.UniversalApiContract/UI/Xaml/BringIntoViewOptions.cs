// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.BringIntoViewOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Represents the options that can be applied when an element is brought into view.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class BringIntoViewOptions : IBringIntoViewOptions, IBringIntoViewOptions2
  {
    /// <summary>Initializes a new instance of the BringIntoViewOptions class.</summary>
    [MethodImpl]
    public extern BringIntoViewOptions();

    /// <summary>Gets or sets a value that indicates whether to use animation when the element is brought into view.</summary>
    /// <returns>**true** to use animation; otherwise, **false**. The default is **true**.</returns>
    public extern bool AnimationDesired { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the area of an element to bring into view.</summary>
    /// <returns>A rectangle that defines the area of an element to bring into view.</returns>
    public extern IReference<Rect> TargetRect { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Controls the positioning of the vertical axis of the TargetRect with respect to the vertical axis of the viewport. The value is clamped from 0.0f to 1.0f with 0.0f representing the left vertical edge and 1.0f representing the right vertical edge. By default this is set to 0.0f.</summary>
    /// <returns>A value that specifies the positioning of the vertical axis of the TargetRect with respect to the vertical axis of the viewport. The default is 0.0f.</returns>
    public extern double HorizontalAlignmentRatio { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Controls the positioning of the horizontal axis of the TargetRect with respect to the horizontal axis of the viewport. The value is clamped from 0.0f to 1.0f with 0.0f representing the top horizontal edge and 1.0f representing the bottom horizontal edge. By default this is set to 0.0f.</summary>
    /// <returns>A value that specifies the positioning of the horizontal axis of the TargetRect with respect to the horizontal axis of the viewport. The default is 0.0f.</returns>
    public extern double VerticalAlignmentRatio { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the horizontal distance to add to the viewport-relative position of the TargetRect after satisfying the requested HorizontalAlignmentRatio.</summary>
    /// <returns>The horizontal distance to add to the viewport-relative position of the TargetRect after satisfying the requested HorizontalAlignmentRatio.</returns>
    public extern double HorizontalOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the vertical distance to add to the viewport-relative position of the TargetRect after satisfying the requested VerticalAlignmentRatio.</summary>
    /// <returns>The vertical distance to add to the viewport-relative position of the TargetRect after satisfying the requested VerticalAlignmentRatio.</returns>
    public extern double VerticalOffset { [MethodImpl] get; [MethodImpl] set; }
  }
}
