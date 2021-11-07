﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackItemError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Represents an error that occurred trying to resolve a MediaPlaybackItem.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaPlaybackItemError : IMediaPlaybackItemError
  {
    /// <summary>Gets the error code associated with the playback item error.</summary>
    /// <returns>The error code associated with the playback item error.</returns>
    public extern MediaPlaybackItemErrorCode ErrorCode { [MethodImpl] get; }

    /// <summary>Gets the extended error code for the MediaPlaybackItem error.</summary>
    /// <returns>The error code.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}