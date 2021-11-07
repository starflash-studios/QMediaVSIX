﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedMetadataTrackFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Provides data for the TimedMetadataTrack.TrackFailed event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TimedMetadataTrackFailedEventArgs : ITimedMetadataTrackFailedEventArgs
  {
    /// <summary>Gets an object representing the error that occurred with the timed metadata track.</summary>
    /// <returns>An object representing the error that occurred with the timed metadata track.</returns>
    public extern TimedMetadataTrackError Error { [MethodImpl] get; }
  }
}