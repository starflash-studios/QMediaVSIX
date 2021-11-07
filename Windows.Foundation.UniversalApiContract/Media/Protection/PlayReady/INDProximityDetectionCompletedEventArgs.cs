// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDProximityDetectionCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Provides arguments for the PlayReady-ND ProximityDetectionCompleted event. Apps fire this event after they complete the proximity detection process.</summary>
  /// <deprecated type="deprecate">INDProximityDetectionCompletedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("INDProximityDetectionCompletedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Guid(712008488, 55845, 20364, 158, 183, 93, 15, 195, 101, 139, 202)]
  public interface INDProximityDetectionCompletedEventArgs
  {
    /// <summary>Gets the number of retries that occurred during a proximity detection operation.</summary>
    /// <returns>The number of retries that occurred during a proximity detection operation.</returns>
    uint ProximityDetectionRetryCount { [Deprecated("INDProximityDetectionCompletedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
