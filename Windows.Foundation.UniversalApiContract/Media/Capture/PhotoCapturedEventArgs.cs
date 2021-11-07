// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.PhotoCapturedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Provides data for the photo sequence PhotoCaptured event.</summary>
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PhotoCapturedEventArgs : IPhotoCapturedEventArgs
  {
    /// <summary>Gets the captured image associated with the event.</summary>
    /// <returns>The captured image.</returns>
    public extern CapturedFrame Frame { [MethodImpl] get; }

    /// <summary>Gets a thumbnail version of the captured image associated with the event.</summary>
    /// <returns>The thumbnail image.</returns>
    public extern CapturedFrame Thumbnail { [MethodImpl] get; }

    /// <summary>Gets a value that indicates time offset in the photo sequence.</summary>
    /// <returns>The</returns>
    public extern TimeSpan CaptureTimeOffset { [MethodImpl] get; }
  }
}
