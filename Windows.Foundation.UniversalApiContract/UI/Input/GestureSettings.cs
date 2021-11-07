// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.GestureSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Specifies the interactions that are supported by an application.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum GestureSettings : uint
  {
    /// <summary>Disable support for gestures and manipulations.</summary>
    None = 0,
    /// <summary>Enable support for the tap gesture.</summary>
    Tap = 1,
    /// <summary>Enable support for the double-tap gesture.</summary>
    DoubleTap = 2,
    /// <summary>Enable support for the press and hold gesture (from a single touch or pen/stylus contact). The Holding event is raised if a time threshold is crossed before the contact is lifted, an additional contact is detected, or a gesture is started.</summary>
    Hold = 4,
    /// <summary>Enable support for the press and hold gesture through the left button on a mouse. The Holding event is raised if a time threshold is crossed before the left button is released or a gesture is started.This gesture can be used to display a context menu.</summary>
    HoldWithMouse = 8,
    /// <summary>Enable support for a right-tap interaction. The RightTapped event is raised when the contact is lifted or the mouse button released.</summary>
    RightTap = 16, // 0x00000010
    /// <summary>Enable support for the slide or swipe gesture with a mouse or pen/stylus (single contact). The Dragging event is raised when either gesture is detected.This gesture can be used for text selection, selecting or rearranging objects, or scrolling and panning.</summary>
    Drag = 32, // 0x00000020
    /// <summary>Enable support for the slide gesture through pointer input, on the horizontal axis. The ManipulationStarted, ManipulationUpdated, and ManipulationCompleted events are all raised during the course of this interaction.This gesture can be used for rearranging objects.</summary>
    ManipulationTranslateX = 64, // 0x00000040
    /// <summary>Enable support for the slide gesture through pointer input, on the vertical axis. The ManipulationStarted, ManipulationUpdated, and ManipulationCompleted events are all raised during the course of this interaction.This gesture can be used for rearranging objects.</summary>
    ManipulationTranslateY = 128, // 0x00000080
    /// <summary>Enable support for the slide gesture through pointer input, on the horizontal axis using rails (guides). The ManipulationStarted, ManipulationUpdated, and ManipulationCompleted events are all raised during the course of this interaction.This gesture can be used for rearranging objects.</summary>
    ManipulationTranslateRailsX = 256, // 0x00000100
    /// <summary>Enable support for the slide gesture through pointer input, on the vertical axis using rails (guides). The ManipulationStarted, ManipulationUpdated, and ManipulationCompleted events are all raised during the course of this interaction.This gesture can be used for rearranging objects.</summary>
    ManipulationTranslateRailsY = 512, // 0x00000200
    /// <summary>Enable support for the rotation gesture through pointer input. The ManipulationStarted, ManipulationUpdated, and ManipulationCompleted events are all raised during the course of this interaction.</summary>
    ManipulationRotate = 1024, // 0x00000400
    /// <summary>Enable support for the pinch or stretch gesture through pointer input.These gestures can be used for optical or semantic zoom and resizing an object. The ManipulationStarted, ManipulationUpdated, and ManipulationCompleted events are all raised during the course of this interaction.</summary>
    ManipulationScale = 2048, // 0x00000800
    /// <summary>Enable support for translation inertia after the slide gesture (through pointer input) is complete. The ManipulationInertiaStarting event is raised if inertia is enabled.</summary>
    ManipulationTranslateInertia = 4096, // 0x00001000
    /// <summary>Enable support for rotation inertia after the rotate gesture (through pointer input) is complete. The ManipulationInertiaStarting event is raised if inertia is enabled.</summary>
    ManipulationRotateInertia = 8192, // 0x00002000
    /// <summary>Enable support for scaling inertia after the pinch or stretch gesture (through pointer input) is complete. The ManipulationInertiaStarting event is raised if inertia is enabled.</summary>
    ManipulationScaleInertia = 16384, // 0x00004000
    /// <summary>Enable support for the CrossSliding interaction when using the slide or swipe gesture through a single touch contact.This gesture can be used for selecting or rearranging objects.</summary>
    CrossSlide = 32768, // 0x00008000
    /// <summary>Enable panning and disable zoom when two or more touch contacts are detected.Prevents unintentional zoom interactions when panning with multiple fingers.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ManipulationMultipleFingerPanning = 65536, // 0x00010000
  }
}
