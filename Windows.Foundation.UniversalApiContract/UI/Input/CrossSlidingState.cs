// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.CrossSlidingState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Specifies the possible states of the CrossSliding event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CrossSlidingState
  {
    /// <summary>A CrossSliding interaction has been detected.</summary>
    Started,
    /// <summary>A CrossSliding interaction has started but the swipe or slide gesture has not crossed the minimum distance threshold for a selection action. (See the Remarks section for a diagram showing the CrossSliding distance thresholds.)</summary>
    Dragging,
    /// <summary>The swipe or slide gesture has crossed the minimum distance threshold for a selection action but has not crossed the minimum distance threshold of the rearrange action. This state is valid only when SpeedBumpStart is disabled in a GestureRecognizer.</summary>
    Selecting,
    /// <summary>The swipe or slide gesture has crossed the minimum distance threshold for a selection action (and the selection speed bump) but has not crossed the maximum distance threshold of the selection speed bump. This state is valid only when both SpeedBumpStart and SelectionStart are enabled in a GestureRecognizer.</summary>
    SelectSpeedBumping,
    /// <summary>The swipe or slide gesture has crossed the minimum distance threshold for a selection action (and the selection speed bump) but has not crossed the maximum distance threshold of the selection speed bump. This state is valid only when SpeedBumpStart is enabled and SelectionStart is disabled in a GestureRecognizer.</summary>
    SpeedBumping,
    /// <summary>The swipe or slide gesture has crossed the minimum distance threshold of the rearrange action. This state is valid only when RearrangeStart is enabled in a GestureRecognizer.</summary>
    Rearranging,
    /// <summary>The swipe or slide gesture has stopped, the CrossSliding interaction has been completed, and the touch contact lifted.</summary>
    Completed,
  }
}
