// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.HandwritingView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a Windows Ink input surface for text input controls.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Static(typeof (IHandwritingViewStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IHandwritingViewStatics2), 720896, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Composable(typeof (IHandwritingViewFactory), CompositionType.Public, 393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class HandwritingView : Control, IHandwritingView, IHandwritingView2
  {
    /// <summary>Initializes a new instance of the HandwritingView class.</summary>
    [MethodImpl]
    public extern HandwritingView();

    /// <summary>Gets or sets the visual element or control that the handwriting view should be positioned in relation to when opened.</summary>
    /// <returns>The visual element or control that the handwriting view should be positioned in relation to when opened. The default is **null**.</returns>
    public extern UIElement PlacementTarget { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the anchor point used to place the handwriting view over the control.</summary>
    /// <returns>An enunmeration value that specifies the anchor point used to place the handwriting view. The default is **Auto**.</returns>
    public extern HandwritingPanelPlacementAlignment PlacementAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the handwriting view panel is open.</summary>
    /// <returns>**true** if the handwriting view panel is open; otherwise, **false**.</returns>
    public extern bool IsOpen { [MethodImpl] get; }

    /// <summary>Gets or sets a value that specifies whether auto-completion candidates are shown as the use writes.</summary>
    /// <returns>**true** if auto-completion candidates are shown as the use writes; otherwise, **false**. The default is **true**.</returns>
    public extern bool AreCandidatesEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the handwriting view panel is opened.</summary>
    public extern event TypedEventHandler<HandwritingView, HandwritingPanelOpenedEventArgs> Opened;

    /// <summary>Occurs when the handwriting view panel is closed.</summary>
    public extern event TypedEventHandler<HandwritingView, HandwritingPanelClosedEventArgs> Closed;

    /// <summary>Attempts to close the handwriting view panel.</summary>
    /// <returns>**true** if the handwriting view panel closed; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool TryClose();

    /// <summary>Attempts to open the handwriting view panel.</summary>
    /// <returns>**true** if the handwriting view panel opened; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool TryOpen();

    public extern bool IsSwitchToKeyboardEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCommandBarOpen { [MethodImpl] get; [MethodImpl] set; }

    public extern CoreInputDeviceTypes InputDeviceTypes { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<HandwritingView, HandwritingViewCandidatesChangedEventArgs> CandidatesChanged;

    public extern event TypedEventHandler<HandwritingView, HandwritingViewTextSubmittedEventArgs> TextSubmitted;

    [MethodImpl]
    public extern IVectorView<string> GetCandidates(uint candidatesSessionId);

    [MethodImpl]
    public extern void SelectCandidate(uint candidatesSessionId, uint selectedCandidateIndex);

    public static extern DependencyProperty IsSwitchToKeyboardEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty IsCommandBarOpenProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlacementTarget dependency property.</summary>
    /// <returns>The identifier for the PlacementTarget dependency property.</returns>
    public static extern DependencyProperty PlacementTargetProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlacementAlignment dependency property.</summary>
    /// <returns>The identifier for the PlacementAlignment dependency property.</returns>
    public static extern DependencyProperty PlacementAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsOpen dependency property.</summary>
    /// <returns>The identifier for the IsOpen dependency property.</returns>
    public static extern DependencyProperty IsOpenProperty { [MethodImpl] get; }

    /// <summary>Identifies the AreCandidatesEnabled dependency property.</summary>
    /// <returns>The identifier for the AreCandidatesEnabled dependency property.</returns>
    public static extern DependencyProperty AreCandidatesEnabledProperty { [MethodImpl] get; }
  }
}
