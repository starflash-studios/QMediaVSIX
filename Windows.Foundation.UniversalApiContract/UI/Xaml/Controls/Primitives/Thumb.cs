// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.Thumb
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents a control that can be dragged by the user.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IThumbStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Thumb : Control, IThumb
  {
    /// <summary>Initializes a new instance of the Thumb class.</summary>
    [MethodImpl]
    public extern Thumb();

    /// <summary>Gets whether the Thumb control has focus and mouse capture.</summary>
    /// <returns>**true** if the Thumb control has focus and mouse capture; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsDragging { [MethodImpl] get; }

    /// <summary>Fires when a Thumb control receives logical focus and mouse capture.</summary>
    public extern event DragStartedEventHandler DragStarted;

    /// <summary>Fires one or more times as the mouse pointer is moved when a Thumb control has logical focus and mouse capture.</summary>
    public extern event DragDeltaEventHandler DragDelta;

    /// <summary>Fires when the Thumb control loses mouse capture.</summary>
    public extern event DragCompletedEventHandler DragCompleted;

    /// <summary>Cancels a drag operation for the Thumb.</summary>
    [MethodImpl]
    public extern void CancelDrag();

    /// <summary>Identifies the IsDragging dependency property.</summary>
    /// <returns>The identifier for the IsDragging dependency property.</returns>
    public static extern DependencyProperty IsDraggingProperty { [MethodImpl] get; }
  }
}
