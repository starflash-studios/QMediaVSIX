// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.FaceDetectionEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents an effect that attempts to detect faces in a video stream.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class FaceDetectionEffect : IFaceDetectionEffect, IMediaExtension
  {
    /// <summary>Gets or sets a value indicating whether face detection is enabled.</summary>
    /// <returns>True if face detection is enabled; otherwise, false.</returns>
    public extern bool Enabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the time span for which face detection should be performed.</summary>
    /// <returns>The time span for which face detection should be performed.</returns>
    public extern TimeSpan DesiredDetectionInterval { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Occurs when a face is detected. See FaceDetectedEventArgs.</summary>
    public extern event TypedEventHandler<FaceDetectionEffect, FaceDetectedEventArgs> FaceDetected;

    /// <summary>Sets properties on the IMediaExtension.</summary>
    /// <param name="configuration">The property set.</param>
    [MethodImpl]
    public extern void SetProperties(IPropertySet configuration);
  }
}
