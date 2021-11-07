// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.Preview.GazeInputSourcePreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input.Preview
{
  /// <summary>Represents the eyes and head of the user identified by an eye-tracking device.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Static(typeof (IGazeInputSourcePreviewStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GazeInputSourcePreview : IGazeInputSourcePreview
  {
    /// <summary>Occurs when the eye-tracking device detects eye movement and the gaze pointer remains within the bounding rectangle of the element.</summary>
    public extern event TypedEventHandler<GazeInputSourcePreview, GazeMovedPreviewEventArgs> GazeMoved;

    /// <summary>Occurs when the eye-tracking device detects that the gaze point has entered the bounding area of the element.</summary>
    public extern event TypedEventHandler<GazeInputSourcePreview, GazeEnteredPreviewEventArgs> GazeEntered;

    /// <summary>Occurs when the eye-tracking device detects that the gaze point has moved outside the bounding area of the element.</summary>
    public extern event TypedEventHandler<GazeInputSourcePreview, GazeExitedPreviewEventArgs> GazeExited;

    /// <summary>Retrieves a reference to the user identified by an eye-tracking device, bound to the active application.</summary>
    /// <returns>A GazeInputSourcePreview object bound to the active application.</returns>
    [MethodImpl]
    public static extern GazeInputSourcePreview GetForCurrentView();

    /// <summary>Creates an object for monitoring the state of the eye-tracker device associated with the current view.</summary>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern GazeDeviceWatcherPreview CreateWatcher();
  }
}
