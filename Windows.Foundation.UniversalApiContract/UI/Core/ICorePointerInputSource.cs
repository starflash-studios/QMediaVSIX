// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICorePointerInputSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Defines the behavior of pointer input (for processing on a worker thread).</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3153181464, 58490, 18667, 136, 7, 248, 248, 211, 234, 69, 81)]
  public interface ICorePointerInputSource
  {
    /// <summary>Stops the capture of pointer input data.</summary>
    void ReleasePointerCapture();

    /// <summary>Starts the capture of pointer input data, if the pointer input device supports it.</summary>
    void SetPointerCapture();

    /// <summary>Occurs if the pointer input source has capture functionality.</summary>
    /// <returns>True if the pointer input source has capture functionality; false if it does not.</returns>
    bool HasCapture { get; }

    /// <summary>Gets the current position of the pointer in screen coordinates.</summary>
    /// <returns>The current position of the pointer, in screen coordinates.</returns>
    Point PointerPosition { get; }

    /// <summary>Gets or sets the current pointer cursor type.</summary>
    /// <returns>The current pointer cursor.</returns>
    CoreCursor PointerCursor { get; set; }

    /// <summary>Occurs when the pointer input capture stream fails or is lost.</summary>
    event TypedEventHandler<object, PointerEventArgs> PointerCaptureLost;

    /// <summary>Occurs when the pointer enters a UI element.</summary>
    event TypedEventHandler<object, PointerEventArgs> PointerEntered;

    /// <summary>Occurs when the pointer exits a UI element.</summary>
    event TypedEventHandler<object, PointerEventArgs> PointerExited;

    /// <summary>Occurs when the pointer is moved.</summary>
    event TypedEventHandler<object, PointerEventArgs> PointerMoved;

    /// <summary>Occurs when a press action (such as a screen press or mouse click) is received for the pointer.</summary>
    event TypedEventHandler<object, PointerEventArgs> PointerPressed;

    /// <summary>Occurs when a release action (such as a screen press-release or mouse click-release) is received for the pointer.</summary>
    event TypedEventHandler<object, PointerEventArgs> PointerReleased;

    /// <summary>Occurs when the pointer wheel (mouse or virtual) has changed position.</summary>
    event TypedEventHandler<object, PointerEventArgs> PointerWheelChanged;
  }
}
