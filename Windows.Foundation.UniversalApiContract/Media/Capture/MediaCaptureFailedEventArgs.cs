// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.MediaCaptureFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Provides data for the MediaCapture.Failed event.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaCaptureFailedEventArgs : IMediaCaptureFailedEventArgs
  {
    /// <summary>A message string for the error.</summary>
    /// <returns>The message string.</returns>
    public extern string Message { [MethodImpl] get; }

    /// <summary>The error code of the error that caused the event.</summary>
    /// <returns>The error code.</returns>
    public extern uint Code { [MethodImpl] get; }
  }
}
