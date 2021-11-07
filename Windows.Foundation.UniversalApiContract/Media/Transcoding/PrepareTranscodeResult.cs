// Decompiled with JetBrains decompiler
// Type: Windows.Media.Transcoding.PrepareTranscodeResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Transcoding
{
  /// <summary>Represents an asynchronous media transcode deferral operation which can be used to start the transcode operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PrepareTranscodeResult : IPrepareTranscodeResult
  {
    /// <summary>Indicates whether the trancode operation can be performed successfully.</summary>
    /// <returns>True if the trancode operation can be performed successfully; false otherwise.</returns>
    public extern bool CanTranscode { [MethodImpl] get; }

    /// <summary>Specifies the reason for the transcode failure.</summary>
    /// <returns>The reason for the transcode failure.</returns>
    public extern TranscodeFailureReason FailureReason { [MethodImpl] get; }

    /// <summary>Creates an object to perform an asynchronous media transcode operation on media data.</summary>
    /// <returns>An object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncActionWithProgress<double> TranscodeAsync();
  }
}
