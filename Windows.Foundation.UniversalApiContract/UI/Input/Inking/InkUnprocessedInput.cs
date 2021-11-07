// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkUnprocessedInput
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking
{
  /// <summary>Provides properties and events for custom processing of ink data from an InkCanvas control. The data is not processed by the InkPresenter.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class InkUnprocessedInput : IInkUnprocessedInput
  {
    /// <summary>Occurs when a pointer enters the hit test, or bounding, area of an InkCanvas control.</summary>
    public extern event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerEntered;

    /// <summary>Occurs when a pointer is detected over, but not down or in contact with, the hit test, or bounding, area of an InkCanvas control.</summary>
    public extern event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerHovered;

    /// <summary>Occurs when a pointer leaves the hit test, or bounding, area of an InkCanvas control.</summary>
    public extern event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerExited;

    /// <summary>Occurs when a pointer registers contact within the hit test, or bounding, area of an InkCanvas control. This can be when a mouse button is pressed or the digitizer surface is touched by a finger or pen.</summary>
    public extern event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerPressed;

    /// <summary>Occurs when a pointer moves within the hit test, or bounding, area of an InkCanvas control.</summary>
    public extern event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerMoved;

    /// <summary>Can occur when a pointer associated with a PointerPressed event is lifted, or released, while within the hit test, or bounding, area of an InkCanvas control.</summary>
    public extern event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerReleased;

    /// <summary>Occurs when a pointer is no longer detected in, or over, the hit test, or bounding, area of an InkCanvas control.</summary>
    public extern event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerLost;

    /// <summary>Gets the InkPresenter object associated with the InkCanvas control capturing the InkStroke data. The InkPresenter does not process the input, instead the data is passed through for custom processing by the app.</summary>
    /// <returns>The ink presenter associated with the pen input.</returns>
    public extern InkPresenter InkPresenter { [MethodImpl] get; }
  }
}
