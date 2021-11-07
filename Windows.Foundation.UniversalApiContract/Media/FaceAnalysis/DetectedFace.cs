// Decompiled with JetBrains decompiler
// Type: Windows.Media.FaceAnalysis.DetectedFace
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.FaceAnalysis
{
  /// <summary>Represents a face that was detected in a SoftwareBitmap or a VideoFrame.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DetectedFace : IDetectedFace
  {
    /// <summary>Gets the bounds the detected face occupies in the SoftwareBitmap or VideoFrame.</summary>
    /// <returns>The bounds of the detected face.</returns>
    public extern BitmapBounds FaceBox { [MethodImpl] get; }
  }
}
