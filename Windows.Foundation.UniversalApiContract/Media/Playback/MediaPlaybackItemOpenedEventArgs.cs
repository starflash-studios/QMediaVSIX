﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlaybackItemOpenedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Provides data for the MediaPlaybackList.ItemOpened event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaPlaybackItemOpenedEventArgs : IMediaPlaybackItemOpenedEventArgs
  {
    /// <summary>Gets the MediaPlaybackItem that was successfully opened.</summary>
    /// <returns>The MediaPlaybackItem that was successfully opened.</returns>
    public extern MediaPlaybackItem Item { [MethodImpl] get; }
  }
}