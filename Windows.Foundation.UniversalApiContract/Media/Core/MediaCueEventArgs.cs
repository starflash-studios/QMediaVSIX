﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaCueEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Provides data for the TimedMetadataTrack.CueEntered and TimedMetadataTrack.CueExited events.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class MediaCueEventArgs : IMediaCueEventArgs
  {
    /// <summary>Gets the cue that triggered the event.</summary>
    /// <returns>The cue that triggered the event.</returns>
    public extern IMediaCue Cue { [MethodImpl] get; }
  }
}