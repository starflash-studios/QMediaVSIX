// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.CapturedPhoto
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Represents a photo taken from a capture device such as a webcam attached.</summary>
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CapturedPhoto : ICapturedPhoto
  {
    /// <summary>Gets the photo data, represented as CapturedFrame object, associated with the CapturedPhoto object.</summary>
    /// <returns>The captured frame.</returns>
    public extern CapturedFrame Frame { [MethodImpl] get; }

    /// <summary>Represents a thumbnail image of the capture photo.</summary>
    /// <returns>The thumbnail image.</returns>
    public extern CapturedFrame Thumbnail { [MethodImpl] get; }
  }
}
