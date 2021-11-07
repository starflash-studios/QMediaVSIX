// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.MediaPlayerRateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  /// <summary>Provides the data for MediaPlayerRateChanged events.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaPlayerRateChangedEventArgs : IMediaPlayerRateChangedEventArgs
  {
    /// <summary>Gets the new playback rate for the media.</summary>
    /// <returns>The new playback rate for the media.</returns>
    public extern double NewRate { [MethodImpl] get; }
  }
}
