﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.PhotoConfirmationCapturedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Provides data for the PhotoConfirmationCaptured event.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PhotoConfirmationCapturedEventArgs : IPhotoConfirmationCapturedEventArgs
  {
    /// <summary>Gets the captured frame.</summary>
    /// <returns>The captured frame.</returns>
    public extern CapturedFrame Frame { [MethodImpl] get; }

    /// <summary>Gets the time offset from when capture began to the capture of the frame associated with the event.</summary>
    /// <returns>The time offset from when capture began to the capture of the frame associated with the event.</returns>
    public extern TimeSpan CaptureTimeOffset { [MethodImpl] get; }
  }
}