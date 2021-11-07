// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureRelativePanelWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Monitors the panel associated with a DisplayRegion, so that the app receives notifications when the relative location of the panel changes.</summary>
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public sealed class MediaCaptureRelativePanelWatcher : IMediaCaptureRelativePanelWatcher, IClosable
  {
    /// <summary>Gets the relative panel that the MediaCaptureRelativePanelWatcher monitors for changes.</summary>
    /// <returns>A value from the Windows.Devices.Enumeration.Panel enumeration, indicating the relative panel that the MediaCaptureRelativePanelWatcher monitors for changes.</returns>
    public extern Panel RelativePanel { [MethodImpl] get; }

    /// <summary>Raised when the relative location of the panel being monitored by the MediaCaptureRelativePanelWatcher changes.</summary>
    public extern event TypedEventHandler<MediaCaptureRelativePanelWatcher, object> Changed;

    /// <summary>Starts the MediaCaptureRelativePanelWatcher monitoring of the relative panel location of the associated DisplayRegion.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the MediaCaptureRelativePanelWatcher monitoring of the relative panel location of the associated DisplayRegion.</summary>
    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern void Close();
  }
}
