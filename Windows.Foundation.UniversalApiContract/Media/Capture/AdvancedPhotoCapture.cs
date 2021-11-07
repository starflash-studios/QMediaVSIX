// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.AdvancedPhotoCapture
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  /// <summary>Provides methods for capturing photos using system-provided computational photography techniques.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class AdvancedPhotoCapture : IAdvancedPhotoCapture
  {
    /// <summary>Asynchronously performs an advanced photo capture.</summary>
    /// <returns>An asynchronous operation that returns an AdvancedCapturedPhoto upon successful completion.</returns>
    [RemoteAsync]
    [Overload("CaptureAsync")]
    [MethodImpl]
    public extern IAsyncOperation<AdvancedCapturedPhoto> CaptureAsync();

    /// <summary>Asynchronously performs an advanced photo capture passing the provided app-defined context object to the result of the operation.</summary>
    /// <param name="context">An app-defined context object that passes context information to the result of the operation.</param>
    /// <returns>An asynchronous operation that returns an AdvancedCapturedPhoto upon successful completion.</returns>
    [Overload("CaptureWithContextAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AdvancedCapturedPhoto> CaptureAsync(
      object context);

    /// <summary>Raised when a reference photo for the advanced photo operation has been captured, on devices that support this feature.</summary>
    public extern event TypedEventHandler<AdvancedPhotoCapture, OptionalReferencePhotoCapturedEventArgs> OptionalReferencePhotoCaptured;

    /// <summary>Occurs when all of the frames required for the advanced photo capture have been captured.</summary>
    public extern event TypedEventHandler<AdvancedPhotoCapture, object> AllPhotosCaptured;

    /// <summary>Asynchronously releases the AdvancedPhotoCapture object and resources used by the advanced photo capture operation.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction FinishAsync();
  }
}
