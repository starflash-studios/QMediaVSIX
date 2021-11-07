// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.OptionalReferencePhotoCapturedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Provides data for the AdvancedPhotoCapture.OptionalReferencePhotoCaptured event.</summary>
  [Threading(ThreadingModel.Both)]
  [GCPressure(amount = GCPressureAmount.High)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class OptionalReferencePhotoCapturedEventArgs : 
    IOptionalReferencePhotoCapturedEventArgs
  {
    /// <summary>Gets the captured frame containing the reference photo from the advanced photo capture.</summary>
    /// <returns>The captured frame containing the reference photo.</returns>
    public extern CapturedFrame Frame { [MethodImpl] get; }

    /// <summary>Gets the app-defined context object associated with the advanced photo capture operation, if one was provided in the call to AdvancedPhotoCapture.CaptureAsync(Object).</summary>
    /// <returns>The app-defined context object associated with the advanced photo capture operation.</returns>
    public extern object Context { [MethodImpl] get; }
  }
}
