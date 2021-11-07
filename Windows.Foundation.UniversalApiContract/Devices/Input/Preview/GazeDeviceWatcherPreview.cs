// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.Preview.GazeDeviceWatcherPreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input.Preview
{
  /// <summary>Dynamically detects and enumerates eye-tracking devices, and receives event notifications when a device is added, removed, or updated after the initial enumeration.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GazeDeviceWatcherPreview : IGazeDeviceWatcherPreview
  {
    /// <summary>Occurs when a new eye-tracker device is detected.</summary>
    public extern event TypedEventHandler<GazeDeviceWatcherPreview, GazeDeviceWatcherAddedPreviewEventArgs> Added;

    /// <summary>Occurs when an existing eye-tracker device is no longer detected.</summary>
    public extern event TypedEventHandler<GazeDeviceWatcherPreview, GazeDeviceWatcherRemovedPreviewEventArgs> Removed;

    /// <summary>Occurs when an update is made to an existing eye-tracker device, such as calibration.</summary>
    public extern event TypedEventHandler<GazeDeviceWatcherPreview, GazeDeviceWatcherUpdatedPreviewEventArgs> Updated;

    /// <summary>Occurs when the GazeDeviceWatcherPreview finishes identifying the connected eye-tracker devices.</summary>
    public extern event TypedEventHandler<GazeDeviceWatcherPreview, object> EnumerationCompleted;

    /// <summary>Starts monitoring the state of an eye-tracker device.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops monitoring the state of an eye-tracker device.</summary>
    [MethodImpl]
    public extern void Stop();
  }
}
