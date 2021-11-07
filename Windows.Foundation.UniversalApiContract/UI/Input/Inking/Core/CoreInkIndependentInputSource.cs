// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.CoreInkIndependentInputSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking.Core
{
  /// <summary>Provides properties, methods, and events for handling pointer input prior to processing by an InkPresenter object.</summary>
  [DualApiPartition(version = 167772160)]
  [Static(typeof (ICoreInkIndependentInputSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CoreInkIndependentInputSource : 
    ICoreInkIndependentInputSource,
    ICoreInkIndependentInputSource2
  {
    /// <summary>Occurs as a pointer is detected entering the hit test, or bounding, area of the InkCanvas associated with the InkPresenter object.</summary>
    public extern event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerEntering;

    /// <summary>Occurs as a pointer is detected over, but not down or in contact with, the hit test, or bounding, area of the InkCanvas associated with the InkPresenter object.</summary>
    public extern event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerHovering;

    /// <summary>Occurs as a pointer is detected leaving the hit test, or bounding, area of the InkCanvas associated with the InkPresenter object.</summary>
    public extern event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerExiting;

    /// <summary>Occurs as a pointer registers contact within the hit test, or bounding, area of the InkCanvas associated with the InkPresenter object. This can be when a mouse button is pressed or the digitizer surface is touched by a finger or pen.</summary>
    public extern event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerPressing;

    /// <summary>Occurs as a pointer moves within the hit test, or bounding, area of the InkCanvas associated with the InkPresenter object.</summary>
    public extern event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerMoving;

    /// <summary>Can occur as a pointer associated with a PointerPressing event is lifted, or released, while within the hit test, or bounding, area of the InkCanvas associated with the InkPresenter object.</summary>
    public extern event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerReleasing;

    /// <summary>Occurs as a pointer is no longer detected in, or over, the hit test, or bounding, area of the InkCanvas associated with the InkPresenter object.</summary>
    public extern event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerLost;

    /// <summary>Gets the InkPresenter object that manages the input, processing, and rendering of ink stroke data.</summary>
    /// <returns>Object that manages the input, processing, and rendering of ink stroke data for an InkCanvas control.</returns>
    public extern InkPresenter InkPresenter { [MethodImpl] get; }

    public extern CoreCursor PointerCursor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Retrieves a CoreInkIndependentInputSource object for handling pointer input prior to processing by an InkPresenter object.</summary>
    /// <param name="inkPresenter">Object that manages the input, processing, and rendering of InkStroke data for an InkCanvas control.</param>
    /// <returns>Object that handles the pointer input for an InkPresenter object.</returns>
    [MethodImpl]
    public static extern CoreInkIndependentInputSource Create(
      InkPresenter inkPresenter);
  }
}
