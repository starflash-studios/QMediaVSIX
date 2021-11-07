// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureFailedEventHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Represents the method that will handle the MediaCapture.Failed event.</summary>
  /// <param name="sender">The MediaCapture object that raised the event.</param>
  /// <param name="errorEventArgs">Arguments that contain information about the event.</param>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(538243067, 23768, 20232, 163, 20, 13, 54, 13, 165, 159, 20)]
  public delegate void MediaCaptureFailedEventHandler(
    MediaCapture sender,
    MediaCaptureFailedEventArgs errorEventArgs);
}
