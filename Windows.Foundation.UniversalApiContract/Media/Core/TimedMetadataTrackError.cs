// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedMetadataTrackError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Provides information about an error that occurred with a timed metadata track.</summary>
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TimedMetadataTrackError : ITimedMetadataTrackError
  {
    /// <summary>Gets the error code associated with the timed metadata track error.</summary>
    /// <returns>The error code associated with the timed metadata track error.</returns>
    public extern TimedMetadataTrackErrorCode ErrorCode { [MethodImpl] get; }

    /// <summary>Gets the extended error code for the TimedMetadataTrackError.</summary>
    /// <returns>The extended error code for the TimedMetadataTrackError.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
