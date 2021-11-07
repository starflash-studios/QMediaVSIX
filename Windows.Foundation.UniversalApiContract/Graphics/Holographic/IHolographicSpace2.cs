// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicSpace2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (HolographicSpace))]
  [Guid(1333897640, 47103, 18563, 152, 39, 125, 103, 114, 135, 234, 112)]
  internal interface IHolographicSpace2
  {
    HolographicSpaceUserPresence UserPresence { get; }

    event TypedEventHandler<HolographicSpace, object> UserPresenceChanged;

    void WaitForNextFrameReady();

    void WaitForNextFrameReadyWithHeadStart(TimeSpan requestedHeadStartDuration);

    [Deprecated("Use CreateFrameScanoutMonitor instead of CreateFramePresentationMonitor. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
    HolographicFramePresentationMonitor CreateFramePresentationMonitor(
      uint maxQueuedReports);
  }
}
