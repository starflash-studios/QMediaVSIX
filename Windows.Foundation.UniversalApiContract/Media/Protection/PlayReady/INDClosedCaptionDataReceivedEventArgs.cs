// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDClosedCaptionDataReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Specifies arguments for a PlayReady-ND ClosedCaptionDataReceived event.</summary>
  /// <deprecated type="deprecate">INDClosedCaptionDataReceivedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("INDClosedCaptionDataReceivedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Guid(1194906271, 49989, 17993, 132, 104, 184, 197, 252, 53, 113, 144)]
  public interface INDClosedCaptionDataReceivedEventArgs
  {
    /// <summary>Gets the format of the closed caption data.</summary>
    /// <returns>The closed caption data format. This value can be **ATSC**, **SCTE20**, or **Unknown**.</returns>
    NDClosedCaptionFormat ClosedCaptionDataFormat { [Deprecated("INDClosedCaptionDataReceivedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the timestamp of the closed caption data.</summary>
    /// <returns>The timestamp of the closed caption data, in milliseconds.</returns>
    long PresentationTimestamp { [Deprecated("INDClosedCaptionDataReceivedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the closed caption data.</summary>
    /// <returns>The closed caption data.</returns>
    byte[] ClosedCaptionData { [Deprecated("INDClosedCaptionDataReceivedEventArgs is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
